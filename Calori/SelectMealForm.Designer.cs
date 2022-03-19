namespace Calori
{
    partial class SelectMealForm
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
            this.cboSelectMeal = new System.Windows.Forms.ComboBox();
            this.btnSelectAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboSelectMeal
            // 
            this.cboSelectMeal.FormattingEnabled = true;
            this.cboSelectMeal.Location = new System.Drawing.Point(12, 36);
            this.cboSelectMeal.Name = "cboSelectMeal";
            this.cboSelectMeal.Size = new System.Drawing.Size(217, 21);
            this.cboSelectMeal.TabIndex = 0;
            // 
            // btnSelectAdd
            // 
            this.btnSelectAdd.Location = new System.Drawing.Point(154, 74);
            this.btnSelectAdd.Name = "btnSelectAdd";
            this.btnSelectAdd.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAdd.TabIndex = 1;
            this.btnSelectAdd.Text = "SELECT";
            this.btnSelectAdd.UseVisualStyleBackColor = true;
            this.btnSelectAdd.Click += new System.EventHandler(this.btnSelectAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please Select Meal";
            // 
            // SelectMealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 125);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectAdd);
            this.Controls.Add(this.cboSelectMeal);
            this.Name = "SelectMealForm";
            this.Text = "SelectMealForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSelectMeal;
        private System.Windows.Forms.Button btnSelectAdd;
        private System.Windows.Forms.Label label1;
    }
}