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
    public partial class MobileEntry : Form
    {
        MobileManager _mobileManager = new MobileManager(); 
        public MobileEntry()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
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

                if (!String.IsNullOrEmpty(ModeNameTextBox.Text))
                    mobile.ModelName = ModeNameTextBox.Text;

                
                
                
                if (!String.IsNullOrEmpty(priceTextBox.Text))
                    mobile.Price = Convert.ToDouble(priceTextBox.Text);


                bool isExists = _mobileManager.Exists(mobile);


                if (isExists)
                {
                    MessageBox.Show("IME Already Exists");
                }
                else
                {

                    //Save Data    
                    bool isSaved = false;
                    isSaved = _mobileManager.Save(mobile);

                    //9 Show Result
                    if (isSaved)
                    {

                        MessageBox.Show("Saved");
                    }
                    else
                    {
                        MessageBox.Show("Not Saved");
                    }
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                
            }
        }
    }
}
