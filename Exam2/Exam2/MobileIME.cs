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
    public partial class MobileIME : Form
    {
        MobileManager _mobileManager = new MobileManager(); 
        public MobileIME()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                MobileCls mobile = new MobileCls();
                if (!String.IsNullOrEmpty(imeTextBox.Text))
                {
                    mobile.IME = imeTextBox.Text;
                    if (imeTextBox.Text.Length != 15)
                    {
                        MessageBox.Show("IME Number Must be 15 Character");
                        return;
                    }
                }

                bool isExists = _mobileManager.Search(mobile);


                if (isExists)
                {
                    modelNamelabel.Text = mobile.ModelName;
                    imeLabel.Text = mobile.IME;
                    priceLabel.Text = mobile.Price.ToString();
                }
                else
                {
                    modelNamelabel.Text = "";
                    imeLabel.Text = "";
                    priceLabel.Text = "";
                    MessageBox.Show("IME Not Exists");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }
        }
    }
}
