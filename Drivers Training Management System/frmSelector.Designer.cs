namespace Drivers_Training_Management_System
{
    partial class frmSelector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cboQuestionType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnTakeExam = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTakeTraining = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "የጥያቄ አይነት:";
            // 
            // cboQuestionType
            // 
            this.cboQuestionType.FormattingEnabled = true;
            this.cboQuestionType.Items.AddRange(new object[] {
            "Behaviour",
            "Communication",
            "Driving Silit",
            "Dry Cargo",
            "Emergency",
            "Law",
            "Liquid Cargo",
            "Luggage Passenger",
            "Motor Cycle",
            "Yeguzo Mereja",
            "Technic"});
            this.cboQuestionType.Location = new System.Drawing.Point(210, 100);
            this.cboQuestionType.Margin = new System.Windows.Forms.Padding(4);
            this.cboQuestionType.Name = "cboQuestionType";
            this.cboQuestionType.Size = new System.Drawing.Size(303, 24);
            this.cboQuestionType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "የጥያቄ ብዛት:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(210, 140);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(303, 22);
            this.txtAmount.TabIndex = 3;
            // 
            // btnTakeExam
            // 
            this.btnTakeExam.BackColor = System.Drawing.Color.White;
            this.btnTakeExam.Location = new System.Drawing.Point(240, 201);
            this.btnTakeExam.Margin = new System.Windows.Forms.Padding(4);
            this.btnTakeExam.Name = "btnTakeExam";
            this.btnTakeExam.Size = new System.Drawing.Size(215, 47);
            this.btnTakeExam.TabIndex = 4;
            this.btnTakeExam.Text = "ፈተና ጀምር";
            this.btnTakeExam.UseVisualStyleBackColor = false;
            this.btnTakeExam.Click += new System.EventHandler(this.btnTakeExam_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(462, 201);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(215, 47);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "ዝጋ";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(665, 56);
            this.label3.TabIndex = 0;
            this.label3.Text = "የሚፈልጉትን የጥያቄ አይነትና የጥያቄ ብዛት ያስጉቡና ከታች ስልጠና ጀምር ወይም ፈተና ጀምር የሚለውን ይንኩ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTakeTraining
            // 
            this.btnTakeTraining.BackColor = System.Drawing.Color.White;
            this.btnTakeTraining.Location = new System.Drawing.Point(17, 202);
            this.btnTakeTraining.Margin = new System.Windows.Forms.Padding(4);
            this.btnTakeTraining.Name = "btnTakeTraining";
            this.btnTakeTraining.Size = new System.Drawing.Size(215, 47);
            this.btnTakeTraining.TabIndex = 4;
            this.btnTakeTraining.Text = "ስልጠና ጀምር";
            this.btnTakeTraining.UseVisualStyleBackColor = false;
            this.btnTakeTraining.Click += new System.EventHandler(this.btnTakeTraining_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Drivers_Training_Management_System.Properties.Resources.banner;
            this.pictureBox1.Location = new System.Drawing.Point(685, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(733, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Developed by: BT IT Solutions (+251 911 84 20 52)";
            // 
            // frmSelector
            // 
            this.AcceptButton = this.btnTakeTraining;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1079, 275);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnTakeTraining);
            this.Controls.Add(this.btnTakeExam);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboQuestionType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "እንኳን ደህና መጡ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboQuestionType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnTakeExam;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTakeTraining;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}