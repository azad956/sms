using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exam2.BLL;
using Exam2.Models;

namespace Exam2
{
    public partial class MobilePrice : Form
    {
        MobileManager _mobileManager = new MobileManager(); 
        public MobilePrice()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            double lowPrice=0;
            double highPrice=0;

            if (!String.IsNullOrEmpty(lowPriceTextBox.Text))
                lowPrice = Convert.ToDouble(lowPriceTextBox.Text);

            if (!String.IsNullOrEmpty(highPriceTextBox.Text))
                highPrice = Convert.ToDouble(highPriceTextBox.Text);

            MobileCls mobile = new MobileCls();

            List<MobileCls> mobiles = new List<MobileCls>();
            mobiles = _mobileManager.Search(lowPrice, highPrice);
            ShowDataGridView.DataSource = mobiles;
        }
    }
}
