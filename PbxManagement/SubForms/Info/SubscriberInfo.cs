using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PbxManagement.Models;

namespace PbxManagement.InfoForms
{
    public partial class SubscriberInfo : Form
    {
        Subscribers _subscriber = null;
        public SubscriberInfo(Subscribers sub)
        {
            InitializeComponent();
            _subscriber = sub;
        }

        private void SubscriberInfo_Load(object sender, EventArgs e)
        {
            tbInfoId.Text = _subscriber.Id.ToString();
            tbInfoName.Text = _subscriber.Name;
            tbInfoSurname.Text = _subscriber.Surname;
            tbInfoPhoneNumber.Text = _subscriber.PhoneNumber;
            tbInfoBalance.Text = _subscriber.Balance.ToString();

        }
    }

}