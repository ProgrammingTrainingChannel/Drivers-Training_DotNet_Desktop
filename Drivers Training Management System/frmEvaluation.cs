using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drivers_Training_Management_System
{
    public partial class frmEvaluation : Form
    {
        string[] questions;
        int currentQuestionIndex = 0;
        int amount = 0;

        string trainingOrExam = "";

        int answerIndex = 0;
        int correctAnswer = 0;

        public frmEvaluation()
        {
            InitializeComponent();
        }

        private void frmEvaluation_Load(object sender, EventArgs e)
        {
            string selectedType = this.Tag.ToString().Split(',')[0];
            amount = int.Parse(this.Tag.ToString().Split(',')[1]);
            trainingOrExam = this.Tag.ToString().Split(',')[2];

            if (selectedType.Equals("Behaviour"))
            {
                string allQuestion = QuestionTextManager.behaviour;
                questions = allQuestion.Split('$');

                LoadSingleQuestion();
            }
            else if (selectedType.Equals("Law"))
            {
                string allQuestion = QuestionTextManager.law;
                questions = allQuestion.Split('$');

                LoadSingleQuestion();
            }
            else if (selectedType.Equals("Communication"))
            {
                string allQuestion = QuestionTextManager.communication;
                questions = allQuestion.Split('$');

                LoadSingleQuestion();
            }
            else if (selectedType.Equals("Driving Silit"))
            {
                string allQuestion = QuestionTextManager.driving_silit;
                questions = allQuestion.Split('$');

                LoadSingleQuestion();
            }
            else if (selectedType.Equals("Dry Cargo"))
            {
                string allQuestion = QuestionTextManager.dry_cargo;
                questions = allQuestion.Split('$');

                LoadSingleQuestion();
            }
            else if (selectedType.Equals("Emergency"))
            {
                string allQuestion = QuestionTextManager.emergency;
                questions = allQuestion.Split('$');

                LoadSingleQuestion();
            }
            else if (selectedType.Equals("Liquid Cargo"))
            {
                string allQuestion = QuestionTextManager.liquid_cargo;
                questions = allQuestion.Split('$');

                LoadSingleQuestion();
            }
            else if (selectedType.Equals("Luggage Passenger"))
            {
                string allQuestion = QuestionTextManager.luggage_passenger;
                questions = allQuestion.Split('$');

                LoadSingleQuestion();
            }
            else if (selectedType.Equals("Motor Cycle"))
            {
                string allQuestion = QuestionTextManager.motor_cycle;
                questions = allQuestion.Split('$');

                LoadSingleQuestion();
            }
            else if (selectedType.Equals("Yeguzo Mereja"))
            {
                string allQuestion = QuestionTextManager.yeguzo_mereja;
                questions = allQuestion.Split('$');

                LoadSingleQuestion();
            }
            else if (selectedType.Equals("Technic"))
            {
                string allQuestion = QuestionTextManager.technic;
                questions = allQuestion.Split('$');

                LoadSingleQuestion();
            }
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            if (checkBoxChoice1.Checked == true || checkBoxChoice2.Checked == true || 
                checkBoxChoice3.Checked == true || checkBoxChoice4.Checked == true ||
                checkBoxChoice5.Checked == true || checkBoxChoice6.Checked == true)
            {
                EvaluateCurrentQuestion();
                LoadSingleQuestion();
            }
            else
            {
                MessageBox.Show("እባክዎ በቅድሚያ የዚህን ጥያቄ መልሱን ይምረጡ");
            }
        }

        private void frmEvaluation_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void LoadSingleQuestion()
        {
            if (currentQuestionIndex < amount)
            {
                int randomIndex = (new Random()).Next(1, questions.Length);
                string[] singleQuestion = questions[randomIndex].Split('#');
                currentQuestionIndex++;

                lblQuestionText.Text = singleQuestion[0].TrimStart().TrimEnd();

                if (lblQuestionText.Text.IndexOf("(pic") != -1)
                {
                    int starting = lblQuestionText.Text.IndexOf("(");
                    int ending = lblQuestionText.Text.IndexOf(")");

                    string filename = lblQuestionText.Text.Substring(starting + 1, ending - starting - 1);

                    string fullpath = "D:\\Projects\\BT IT Solutions\\Drivers Training - Free\\Drivers Training Management System\\Assets\\" + filename + ".jpg";
                    Image img = Image.FromFile(fullpath);
                    this.pictureBoxQuestion.Image = img;
                    this.pictureBoxQuestion.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    this.pictureBoxQuestion.Image = null;
                }

                lblChoiceText1.Text = "";
                lblChoiceText2.Text = "";
                lblChoiceText3.Text = "";
                lblChoiceText4.Text = "";
                lblChoiceText5.Text = "";
                lblChoiceText6.Text = "";

                checkBoxChoice1.Tag = "";
                checkBoxChoice2.Tag = "";
                checkBoxChoice3.Tag = "";
                checkBoxChoice4.Tag = "";
                checkBoxChoice5.Tag = "";
                checkBoxChoice6.Tag = "";

                checkBoxChoice1.Checked = false;
                checkBoxChoice2.Checked = false;
                checkBoxChoice3.Checked = false;
                checkBoxChoice4.Checked = false;
                checkBoxChoice5.Checked = false;
                checkBoxChoice6.Checked = false;

                checkBoxChoice1.Visible = false;
                checkBoxChoice2.Visible = false;
                checkBoxChoice3.Visible = false;
                checkBoxChoice4.Visible = false;
                checkBoxChoice5.Visible = false;
                checkBoxChoice6.Visible = false;

                pictureBoxChoice1.Visible = false;
                pictureBoxChoice2.Visible = false;
                pictureBoxChoice3.Visible = false;
                pictureBoxChoice4.Visible = false;
                pictureBoxChoice5.Visible = false;
                pictureBoxChoice6.Visible = false;

                if (singleQuestion.Length > 1)
                {
                    checkBoxChoice1.Visible = true;
                    pictureBoxChoice1.Visible = true;

                    lblChoiceText1.Text = singleQuestion[1].TrimStart().TrimEnd();
                    if (lblChoiceText1.Text.Trim().IndexOf("1") > -1)
                    {
                        lblChoiceText1.Text = lblChoiceText1.Text.Replace("- 1", "");
                        checkBoxChoice1.Tag = 1;
                        answerIndex = 1;

                    }

                    if (lblChoiceText1.Text.IndexOf("(pic") != -1)
                    {
                        int starting = lblChoiceText1.Text.IndexOf("(");
                        int ending = lblChoiceText1.Text.IndexOf(")");

                        string filename = lblChoiceText1.Text.Substring(starting + 1, ending - starting - 1);

                        string fullpath = "D:\\Projects\\BT IT Solutions\\Drivers Training - Free\\Drivers Training Management System\\Assets\\" + filename + ".jpg";
                        Image img = Image.FromFile(fullpath);
                        this.pictureBoxChoice1.Image = img;
                        this.pictureBoxChoice1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        this.pictureBoxChoice1.Image = null;
                    }
                }

                if (singleQuestion.Length > 2)
                {
                    checkBoxChoice2.Visible = true;
                    pictureBoxChoice2.Visible = true;

                    lblChoiceText2.Text = singleQuestion[2].TrimStart().TrimEnd();
                    if (lblChoiceText2.Text.Trim().IndexOf("1") > -1)
                    {
                        lblChoiceText2.Text = lblChoiceText2.Text.Replace("- 1", "");
                        checkBoxChoice2.Tag = 2;
                        answerIndex = 2;
                    }

                    if (lblChoiceText2.Text.IndexOf("(pic") != -1)
                    {
                        int starting = lblChoiceText2.Text.IndexOf("(");
                        int ending = lblChoiceText2.Text.IndexOf(")");

                        string filename = lblChoiceText2.Text.Substring(starting + 1, ending - starting - 1);

                        string fullpath = "D:\\Projects\\BT IT Solutions\\Drivers Training - Free\\Drivers Training Management System\\Assets\\" + filename + ".jpg";
                        Image img = Image.FromFile(fullpath);
                        this.pictureBoxChoice2.Image = img;
                        this.pictureBoxChoice2.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        this.pictureBoxChoice2.Image = null;
                    }
                }

                if (singleQuestion.Length > 3)
                {
                    checkBoxChoice3.Visible = true;
                    pictureBoxChoice3.Visible = true;

                    lblChoiceText3.Text = singleQuestion[3].TrimStart().TrimEnd();
                    if (lblChoiceText3.Text.Trim().IndexOf("1") > -1)
                    {
                        lblChoiceText3.Text = lblChoiceText3.Text.Replace("- 1", "");
                        checkBoxChoice3.Tag = 3;
                        answerIndex = 3;
                    }

                    if (lblChoiceText3.Text.IndexOf("(pic") != -1)
                    {
                        int starting = lblChoiceText3.Text.IndexOf("(");
                        int ending = lblChoiceText3.Text.IndexOf(")");

                        string filename = lblChoiceText3.Text.Substring(starting + 1, ending - starting - 1);

                        string fullpath = "D:\\Projects\\BT IT Solutions\\Drivers Training - Free\\Drivers Training Management System\\Assets\\" + filename + ".jpg";
                        Image img = Image.FromFile(fullpath);
                        this.pictureBoxChoice3.Image = img;
                        this.pictureBoxChoice3.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        this.pictureBoxChoice3.Image = null;
                    }
                }

                if (singleQuestion.Length > 4)
                {
                    checkBoxChoice4.Visible = true;
                    pictureBoxChoice4.Visible = true;

                    lblChoiceText4.Text = singleQuestion[4].TrimStart().TrimEnd();
                    if (lblChoiceText4.Text.Trim().Trim().IndexOf("1") > -1)
                    {
                        lblChoiceText4.Text = lblChoiceText4.Text.Replace("- 1", "");
                        checkBoxChoice4.Tag = 4;
                        answerIndex = 4;
                    }

                    if (lblChoiceText4.Text.IndexOf("(pic") != -1)
                    {
                        int starting = lblChoiceText4.Text.IndexOf("(");
                        int ending = lblChoiceText4.Text.IndexOf(")");

                        string filename = lblChoiceText4.Text.Substring(starting + 1, ending - starting - 1);

                        string fullpath = "D:\\Projects\\BT IT Solutions\\Drivers Training - Free\\Drivers Training Management System\\Assets\\" + filename + ".jpg";
                        Image img = Image.FromFile(fullpath);
                        this.pictureBoxChoice4.Image = img;
                        this.pictureBoxChoice4.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        this.pictureBoxChoice4.Image = null;
                    }
                }

                if (singleQuestion.Length > 5)
                {
                    checkBoxChoice5.Visible = true;
                    pictureBoxChoice5.Visible = true;

                    lblChoiceText5.Text = singleQuestion[5].TrimStart().TrimEnd();
                    if (lblChoiceText5.Text.Trim().Trim().IndexOf("1") > -1)
                    {
                        lblChoiceText5.Text = lblChoiceText5.Text.Replace("- 1", "");
                        checkBoxChoice5.Tag = 5;
                        answerIndex = 5;
                    }

                    if (lblChoiceText5.Text.IndexOf("(pic") != -1)
                    {
                        int starting = lblChoiceText5.Text.IndexOf("(");
                        int ending = lblChoiceText5.Text.IndexOf(")");

                        string filename = lblChoiceText5.Text.Substring(starting + 1, ending - starting - 1);

                        string fullpath = "D:\\Projects\\BT IT Solutions\\Drivers Training - Free\\Drivers Training Management System\\Assets\\" + filename + ".jpg";
                        Image img = Image.FromFile(fullpath);
                        this.pictureBoxChoice5.Image = img;
                        this.pictureBoxChoice5.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        this.pictureBoxChoice5.Image = null;
                    }
                }

                if (singleQuestion.Length > 6)
                {
                    checkBoxChoice6.Visible = true;
                    pictureBoxChoice6.Visible = true;

                    lblChoiceText6.Text = singleQuestion[6].TrimStart().TrimEnd();
                    if (lblChoiceText6.Text.Trim().Trim().IndexOf("1") > -1)
                    {
                        lblChoiceText6.Text = lblChoiceText6.Text.Replace("- 1", "");
                        checkBoxChoice6.Tag = 6;
                        answerIndex = 6;
                    }

                    if (lblChoiceText6.Text.IndexOf("(pic") != -1)
                    {
                        int starting = lblChoiceText6.Text.IndexOf("(");
                        int ending = lblChoiceText6.Text.IndexOf(")");

                        string filename = lblChoiceText6.Text.Substring(starting + 1, ending - starting - 1);

                        string fullpath = "D:\\Projects\\BT IT Solutions\\Drivers Training - Free\\Drivers Training Management System\\Assets\\" + filename + ".jpg";
                        Image img = Image.FromFile(fullpath);
                        this.pictureBoxChoice6.Image = img;
                        this.pictureBoxChoice6.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        this.pictureBoxChoice6.Image = null;
                    }
                }
            }
            else
            {
                frmResult result = new frmResult();
                result.Tag = correctAnswer + "," + amount;
                result.ShowDialog();
            }
        }

        private void EvaluateCurrentQuestion()
        {
            if (checkBoxChoice1.Checked == true && checkBoxChoice1.Tag.ToString().Equals(answerIndex.ToString()))
            {
                if (trainingOrExam.Equals("exam"))
                {
                    correctAnswer++;
                }
                else
                {
                    correctAnswer++;
                    frmNotification notification = new frmNotification();
                    notification.Tag = "Correct";
                    notification.ShowDialog();
                }
            }
            else if (checkBoxChoice2.Checked == true && checkBoxChoice2.Tag.ToString().Equals(answerIndex.ToString()))
            {
                if (trainingOrExam.Equals("exam"))
                {
                    correctAnswer++;
                }
                else
                {
                    correctAnswer++;
                    frmNotification notification = new frmNotification();
                    notification.Tag = "Correct";
                    notification.ShowDialog();
                }
            }
            else if (checkBoxChoice3.Checked == true && checkBoxChoice3.Tag.ToString().Equals(answerIndex.ToString()))
            {
                if (trainingOrExam.Equals("exam"))
                {
                    correctAnswer++;
                }
                else
                {
                    correctAnswer++;
                    frmNotification notification = new frmNotification();
                    notification.Tag = "Correct";
                    notification.ShowDialog();
                }
            }
            else if (checkBoxChoice4.Checked == true && checkBoxChoice4.Tag.ToString().Equals(answerIndex.ToString()))
            {
                if (trainingOrExam.Equals("exam"))
                {
                    correctAnswer++;
                }
                else
                {
                    correctAnswer++;
                    frmNotification notification = new frmNotification();
                    notification.Tag = "Correct";
                    notification.ShowDialog();
                }
            }
            else if (checkBoxChoice5.Checked == true && checkBoxChoice5.Tag.ToString().Equals(answerIndex.ToString()))
            {
                if (trainingOrExam.Equals("exam"))
                {
                    correctAnswer++;
                }
                else
                {
                    correctAnswer++;
                    frmNotification notification = new frmNotification();
                    notification.Tag = "Correct";
                    notification.ShowDialog();
                }
            }
            else if (checkBoxChoice6.Checked == true && checkBoxChoice6.Tag.ToString().Equals(answerIndex.ToString()))
            {
                if (trainingOrExam.Equals("exam"))
                {
                    correctAnswer++;
                }
                else
                {
                    correctAnswer++;
                    frmNotification notification = new frmNotification();
                    notification.Tag = "Correct";
                    notification.ShowDialog();
                }
            }
            else
            {
                if (trainingOrExam.Equals("training"))
                {
                    frmNotification notification = new frmNotification();
                    notification.Tag = answerIndex;
                    notification.ShowDialog();
                }
            }
        }

        private void frmEvaluation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timerCounter_Tick(object sender, EventArgs e)
        {
        }

        public Image GetDataToImage(byte[] pData)
        {
            try
            {
                ImageConverter converter = new ImageConverter();
                return (converter.ConvertFrom(pData) as Image);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public byte[] ImageToByteArray(Image img)
        {
            MemoryStream stream = new MemoryStream();
            img.Save(stream, ImageFormat.Jpeg);
            return stream.ToArray();
        }

        private void groupBoxQuestion_Enter(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("የሰራነውን ሶፍትዌር ስለተጠቀሙልን እናመሰግናለን:: \n \nይህ ሶፍትዌር ሙሉ በሙሉ ለተጠቃሚ በነጻ የተዘጋጀ ቢሆንም እንደዚህ አይነት ሌሎችም ሶፍትዌሮች በነጻ ለተጠቃሚ ማድረስ እንድንችል ድጋፍ ማድረግ ከቻሉ በድርጅታችን የባንክ አካውንት ቁጥር BT IT Solutions - 0000 የቻሉትን ያህል ያግዙን እናመሰግናለን::");
        }
    }
}
