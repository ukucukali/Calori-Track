namespace Calori
{
    partial class RegistrationScreenForm
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
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.txtConfirmPasword = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.dtpDateofBirth = new System.Windows.Forms.DateTimePicker();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEmail = new System.Windows.Forms.ComboBox();
            this.lblPassLen = new System.Windows.Forms.Label();
            this.lblPassNum = new System.Windows.Forms.Label();
            this.lblPassSpec = new System.Windows.Forms.Label();
            this.lblPassUp = new System.Windows.Forms.Label();
            this.lblPassLow = new System.Windows.Forms.Label();
            this.lblPassCont = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // nudHeight
            // 
            this.nudHeight.DecimalPlaces = 2;
            this.nudHeight.Location = new System.Drawing.Point(230, 496);
            this.nudHeight.Maximum = new decimal(new int[] {
            212,
            0,
            0,
            131072});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(173, 20);
            this.nudHeight.TabIndex = 43;
            // 
            // txtConfirmPasword
            // 
            this.txtConfirmPasword.Location = new System.Drawing.Point(229, 371);
            this.txtConfirmPasword.Name = "txtConfirmPasword";
            this.txtConfirmPasword.Size = new System.Drawing.Size(173, 20);
            this.txtConfirmPasword.TabIndex = 42;
            this.txtConfirmPasword.TextChanged += new System.EventHandler(this.txtConfirmPasword_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(230, 158);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(173, 20);
            this.txtSurname.TabIndex = 41;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(230, 234);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(80, 20);
            this.txtEmail.TabIndex = 40;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(230, 119);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 20);
            this.txtName.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(119, 500);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Height: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(114, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Gender: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(114, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Surname: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(114, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "E-mail:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(114, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Password: ";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(114, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Confirm Password: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(114, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Date of Birth: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(114, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Weight: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(114, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(216, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "WELCOME";
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Location = new System.Drawing.Point(230, 197);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(173, 21);
            this.cboGender.TabIndex = 28;
            // 
            // nudWeight
            // 
            this.nudWeight.DecimalPlaces = 2;
            this.nudWeight.Location = new System.Drawing.Point(229, 463);
            this.nudWeight.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(173, 20);
            this.nudWeight.TabIndex = 27;
            // 
            // dtpDateofBirth
            // 
            this.dtpDateofBirth.Location = new System.Drawing.Point(229, 431);
            this.dtpDateofBirth.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.dtpDateofBirth.Name = "dtpDateofBirth";
            this.dtpDateofBirth.Size = new System.Drawing.Size(173, 20);
            this.dtpDateofBirth.TabIndex = 26;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.LightGreen;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSignUp.ForeColor = System.Drawing.Color.Black;
            this.btnSignUp.Location = new System.Drawing.Point(230, 543);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(173, 36);
            this.btnSignUp.TabIndex = 25;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(230, 272);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(173, 20);
            this.txtPassword.TabIndex = 24;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(315, 237);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "@";
            // 
            // cboEmail
            // 
            this.cboEmail.FormattingEnabled = true;
            this.cboEmail.Location = new System.Drawing.Point(335, 234);
            this.cboEmail.Margin = new System.Windows.Forms.Padding(2);
            this.cboEmail.Name = "cboEmail";
            this.cboEmail.Size = new System.Drawing.Size(69, 21);
            this.cboEmail.TabIndex = 45;
            // 
            // lblPassLen
            // 
            this.lblPassLen.AutoSize = true;
            this.lblPassLen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPassLen.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblPassLen.Location = new System.Drawing.Point(230, 293);
            this.lblPassLen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassLen.Name = "lblPassLen";
            this.lblPassLen.Size = new System.Drawing.Size(225, 13);
            this.lblPassLen.TabIndex = 46;
            this.lblPassLen.Text = "The password must have at least 6 characters";
            // 
            // lblPassNum
            // 
            this.lblPassNum.AutoSize = true;
            this.lblPassNum.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblPassNum.Location = new System.Drawing.Point(230, 306);
            this.lblPassNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassNum.Name = "lblPassNum";
            this.lblPassNum.Size = new System.Drawing.Size(210, 13);
            this.lblPassNum.TabIndex = 47;
            this.lblPassNum.Text = "The password must have at least 1 number";
            // 
            // lblPassSpec
            // 
            this.lblPassSpec.AutoSize = true;
            this.lblPassSpec.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblPassSpec.Location = new System.Drawing.Point(230, 319);
            this.lblPassSpec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassSpec.Name = "lblPassSpec";
            this.lblPassSpec.Size = new System.Drawing.Size(256, 13);
            this.lblPassSpec.TabIndex = 47;
            this.lblPassSpec.Text = "The password must have at least 1 special character";
            // 
            // lblPassUp
            // 
            this.lblPassUp.AutoSize = true;
            this.lblPassUp.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblPassUp.Location = new System.Drawing.Point(230, 332);
            this.lblPassUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassUp.Name = "lblPassUp";
            this.lblPassUp.Size = new System.Drawing.Size(254, 13);
            this.lblPassUp.TabIndex = 47;
            this.lblPassUp.Text = "The password must have at least 1 upper case letter";
            // 
            // lblPassLow
            // 
            this.lblPassLow.AutoSize = true;
            this.lblPassLow.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblPassLow.Location = new System.Drawing.Point(230, 345);
            this.lblPassLow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassLow.Name = "lblPassLow";
            this.lblPassLow.Size = new System.Drawing.Size(252, 13);
            this.lblPassLow.TabIndex = 47;
            this.lblPassLow.Text = "The password must have at least 1 lower case letter";
            // 
            // lblPassCont
            // 
            this.lblPassCont.AutoSize = true;
            this.lblPassCont.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblPassCont.Location = new System.Drawing.Point(226, 392);
            this.lblPassCont.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassCont.Name = "lblPassCont";
            this.lblPassCont.Size = new System.Drawing.Size(28, 13);
            this.lblPassCont.TabIndex = 48;
            this.lblPassCont.Text = "Text";
            this.lblPassCont.Visible = false;
            // 
            // RegistrationScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 589);
            this.Controls.Add(this.lblPassCont);
            this.Controls.Add(this.lblPassLow);
            this.Controls.Add(this.lblPassUp);
            this.Controls.Add(this.lblPassSpec);
            this.Controls.Add(this.lblPassNum);
            this.Controls.Add(this.lblPassLen);
            this.Controls.Add(this.cboEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudHeight);
            this.Controls.Add(this.txtConfirmPasword);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.nudWeight);
            this.Controls.Add(this.dtpDateofBirth);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtPassword);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegistrationScreenForm";
            this.Text = "RegistrationScreenForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.TextBox txtConfirmPasword;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.DateTimePicker dtpDateofBirth;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEmail;
        private System.Windows.Forms.Label lblPassLen;
        private System.Windows.Forms.Label lblPassNum;
        private System.Windows.Forms.Label lblPassSpec;
        private System.Windows.Forms.Label lblPassUp;
        private System.Windows.Forms.Label lblPassLow;
        private System.Windows.Forms.Label lblPassCont;
    }
}