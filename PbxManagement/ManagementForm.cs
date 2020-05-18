using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PbxManagement.Helpers;
using PbxManagement.InfoForms;
using PbxManagement.SubForms.Update;

namespace PbxManagement
{
    public partial class ManagementForm : Form
    {
        public ManagementForm()
        {
            InitializeComponent();
        }

        private void ManagementForm_Load(object sender, EventArgs e)
        {
            LoadSubscribers();
            LoadUsers();
        }

        private void btnAddSubscriber_Click(object sender, EventArgs e)
        {
            try
            {
                SubscriberHelper.AddSubscriber(tbSubscriberName.Text, tbSubscriberSurname.Text, tbSubscriberPhoneNumber.Text);
                LoadSubscribers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoadSubscribers(string query = null)
        {
            var subscribers = string.IsNullOrEmpty(query) ? SubscriberHelper.GetSubscribers() : SubscriberHelper.SearchSubscribers(query);
            lbSubscribers.Items.Clear();
            lbSubscribers.Items.AddRange(subscribers.Select(x => x.ToString()).ToArray());
        }

        private void LoadUsers(string query = null)
        {
            var users = string.IsNullOrEmpty(query) ? AccountHelper.GetUsers() : AccountHelper.SearchUsers(query);
            lbUsers.Items.Clear();
            lbUsers.Items.AddRange(users.Select(x => x.ToString()).ToArray());
        }

        private void lbSubscribers_SelectedValueChanged(object sender, EventArgs e)
        {
            btnSubscriberShowInfo.Enabled = lbSubscribers.SelectedIndex >= 0;
            btnSubscriberUpdate.Enabled = lbSubscribers.SelectedIndex >= 0;
            btnSubscriberDelete.Enabled = lbSubscribers.SelectedIndex >= 0;
        }

        private void tbSearchSubscriber_TextChanged(object sender, EventArgs e)
        {
            LoadSubscribers(tbSearchSubscriber.Text);
        }

        private void btnSubscriberShowInfo_Click(object sender, EventArgs e)
        {
            var sub = SubscriberHelper.GetSubscribers().Where(x => x.ToString().Equals(lbSubscribers.SelectedItem)).FirstOrDefault();

            var form = new SubscriberInfo(sub);
            form.ShowDialog();
        }

        private void btnSubscriberUpdate_Click(object sender, EventArgs e)
        {
            var sub = SubscriberHelper.GetSubscribers().Where(x => x.ToString().Equals(lbSubscribers.SelectedItem)).FirstOrDefault();

            var form = new SubscriberUpdate(sub);
            form.FormClosed += delegate { LoadSubscribers(); };
            form.ShowDialog();
        }

        private void btnSubscriberDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete this subscriber?", 
                "Deleting", 
                MessageBoxButtons.YesNoCancel, 
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var sub = SubscriberHelper.GetSubscribers().Where(x => x.ToString().Equals(lbSubscribers.SelectedItem)).FirstOrDefault();
                SubscriberHelper.DeleteSubscriber(sub.Id);
                LoadSubscribers();
            }
        }
    }
}
