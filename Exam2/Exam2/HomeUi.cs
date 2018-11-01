using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam2
{
    public partial class HomeUi : Form
    {
        public HomeUi()
        {
            InitializeComponent();
        }

       
     

        private void MobileEntryButton_Click(object sender, EventArgs e)
        {
            MobileEntry mobileEntry = new MobileEntry();
            mobileEntry.Show();
        }

        private void MobilePriceButton_Click(object sender, EventArgs e)
        {
            MobilePrice mobilePrice = new MobilePrice();
            mobilePrice.Show();
        }

        private void MobileIMEButton_Click(object sender, EventArgs e)
        {
            MobileIME mobileIME = new MobileIME();
            mobileIME.Show(); 
        }
    }
}
