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
    public partial class frmResult : Form
    {
        public frmResult()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmResult_Load(object sender, EventArgs e)
        {
            txtTotalQuestion.Text = this.Tag.ToString().Split(',')[1];
            txtCorrectAnswer.Text = this.Tag.ToString().Split(',')[0];
            txtIncorrectAnswer.Text = (int.Parse(txtTotalQuestion.Text) - int.Parse(txtCorrectAnswer.Text)).ToString();
        }

        private void lblResultMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
