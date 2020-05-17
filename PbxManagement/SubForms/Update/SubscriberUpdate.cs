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
using PbxManagement.Models;

namespace PbxManagement.SubForms.Update
{
    public partial class SubscriberUpdate : Form
    {
        Subscribers _subscriber = null;
        public SubscriberUpdate(Subscribers sub)
        {
            InitializeComponent();
            _subscriber = sub;
        }

        private void SubscriberUpdate_Load(object sender, EventArgs e)
        {
            tbId.Text = _subscriber.Id.ToString();
            tbName.Text = _subscriber.Name;
            tbSurname.Text = _subscriber.Surname;
            tbPhoneNumber.Text = _subscriber.PhoneNumber;
            tbBalance.Text = _subscriber.Balance.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SubscriberHelper.UpdateSubscriber(_subscriber.Id, tbName.Text, tbSurname.Text, tbPhoneNumber.Text, tbBalance.Text);
            Close();
        }
    }
}
