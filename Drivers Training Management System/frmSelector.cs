using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Drivers_Training_Management_System
{
    public partial class frmSelector : Form
    {
        public frmSelector()
        {
            InitializeComponent();
        }

        private void btnTakeExam_Click(object sender, EventArgs e)
        {
            if(CheckInput() == true)
            {
                frmEvaluation evaluation = new frmEvaluation();
                evaluation.Tag = cboQuestionType.Text + "," + txtAmount.Text + ",exam";

                evaluation.ShowDialog();
            }
        }

        private void btnTakeTraining_Click(object sender, EventArgs e)
        {
            if (CheckInput() == true)
            {
                frmEvaluation evaluation = new frmEvaluation();
                evaluation.Tag = cboQuestionType.Text + "," + txtAmount.Text + ",training";

                evaluation.ShowDialog();
            }
        }

        private bool CheckInput()
        {
            if (cboQuestionType.Text.Equals("") == true)
            {
                MessageBox.Show("እባክዎ የጥያቄ አይነት ይምረጡ");
                return false;
            }
            else if (txtAmount.Text.Equals("") == true)
            {
                MessageBox.Show("እባክዎ የጥያቄ ብዛት ያስገቡ");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
