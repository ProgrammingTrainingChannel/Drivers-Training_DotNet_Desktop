using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drivers_Training_Management_System
{
    public partial class frmNotification : Form
    {
        public frmNotification()
        {
            InitializeComponent();
        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            timerClose.Enabled = false;
            this.Hide();
        }

        private void frmNotification_Load(object sender, EventArgs e)
        {
            timerClose.Enabled = true;

            if(this.Tag.ToString().Equals("Correct"))
            {
                lblNotification.Text = "በትክክል ተመልሷል：：";
            }
            else
            {
                lblNotification.Text = "መልሱ ትክክል አይደለም：：" + Environment.NewLine + "ትክክለኛው መልስ ： " + this.Tag.ToString() + "ኛው ምርጫ ነው：：";
            }
        }
    }
}
