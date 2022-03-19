namespace Calori
{
    partial class MealForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.btnFoodAdd = new System.Windows.Forms.Button();
            this.nudAddAmount = new System.Windows.Forms.NumericUpDown();
            this.nudAddCalorie = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddImgePath = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddFoodName = new System.Windows.Forms.TextBox();
            this.cboAddCategory = new System.Windows.Forms.ComboBox();
            this.gbMeals = new System.Windows.Forms.GroupBox();
            this.nudPorsion = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pboFoodImage = new System.Windows.Forms.PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dgvFoods = new System.Windows.Forms.DataGridView();
            this.cboFoodName = new System.Windows.Forms.ComboBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.cboAddPorsion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPorsion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddCalorie)).BeginInit();
            this.gbMeals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorsion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboFoodImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(689, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 56;
            this.label1.Text = "Adding Food";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(618, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Category: ";
            // 
            // btnFoodAdd
            // 
            this.btnFoodAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFoodAdd.Location = new System.Drawing.Point(721, 328);
            this.btnFoodAdd.Name = "btnFoodAdd";
            this.btnFoodAdd.Size = new System.Drawing.Size(82, 35);
            this.btnFoodAdd.TabIndex = 53;
            this.btnFoodAdd.Text = "ADD";
            this.btnFoodAdd.UseVisualStyleBackColor = true;
            this.btnFoodAdd.Click += new System.EventHandler(this.btnFoodAdd_Click);
            // 
            // nudAddAmount
            // 
            this.nudAddAmount.DecimalPlaces = 2;
            this.nudAddAmount.Location = new System.Drawing.Point(720, 243);
            this.nudAddAmount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAddAmount.Name = "nudAddAmount";
            this.nudAddAmount.Size = new System.Drawing.Size(162, 20);
            this.nudAddAmount.TabIndex = 52;
            // 
            // nudAddCalorie
            // 
            this.nudAddCalorie.DecimalPlaces = 2;
            this.nudAddCalorie.Location = new System.Drawing.Point(721, 128);
            this.nudAddCalorie.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.nudAddCalorie.Name = "nudAddCalorie";
            this.nudAddCalorie.Size = new System.Drawing.Size(162, 20);
            this.nudAddCalorie.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(618, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Amount: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(618, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Calorie: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(618, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "ImagePath: ";
            // 
            // txtAddImgePath
            // 
            this.txtAddImgePath.Location = new System.Drawing.Point(721, 164);
            this.txtAddImgePath.Name = "txtAddImgePath";
            this.txtAddImgePath.Size = new System.Drawing.Size(161, 20);
            this.txtAddImgePath.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(618, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Food Name: ";
            // 
            // txtAddFoodName
            // 
            this.txtAddFoodName.Location = new System.Drawing.Point(721, 91);
            this.txtAddFoodName.Name = "txtAddFoodName";
            this.txtAddFoodName.Size = new System.Drawing.Size(162, 20);
            this.txtAddFoodName.TabIndex = 43;
            // 
            // cboAddCategory
            // 
            this.cboAddCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAddCategory.FormattingEnabled = true;
            this.cboAddCategory.Location = new System.Drawing.Point(720, 282);
            this.cboAddCategory.Name = "cboAddCategory";
            this.cboAddCategory.Size = new System.Drawing.Size(161, 21);
            this.cboAddCategory.TabIndex = 55;
            // 
            // gbMeals
            // 
            this.gbMeals.Controls.Add(this.lblPorsion);
            this.gbMeals.Controls.Add(this.nudPorsion);
            this.gbMeals.Controls.Add(this.label14);
            this.gbMeals.Controls.Add(this.btnAdd);
            this.gbMeals.Controls.Add(this.pboFoodImage);
            this.gbMeals.Controls.Add(this.label21);
            this.gbMeals.Controls.Add(this.label20);
            this.gbMeals.Controls.Add(this.dgvFoods);
            this.gbMeals.Controls.Add(this.cboFoodName);
            this.gbMeals.Controls.Add(this.cboCategory);
            this.gbMeals.Location = new System.Drawing.Point(12, 12);
            this.gbMeals.Name = "gbMeals";
            this.gbMeals.Size = new System.Drawing.Size(546, 529);
            this.gbMeals.TabIndex = 57;
            this.gbMeals.TabStop = false;
            this.gbMeals.Text = "Meal";
            // 
            // nudPorsion
            // 
            this.nudPorsion.DecimalPlaces = 2;
            this.nudPorsion.Location = new System.Drawing.Point(321, 120);
            this.nudPorsion.Name = "nudPorsion";
            this.nudPorsion.Size = new System.Drawing.Size(64, 20);
            this.nudPorsion.TabIndex = 64;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(258, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 72;
            this.label14.Text = "Porsion: ";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(474, 117);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(49, 23);
            this.btnAdd.TabIndex = 65;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pboFoodImage
            // 
            this.pboFoodImage.Location = new System.Drawing.Point(14, 25);
            this.pboFoodImage.Name = "pboFoodImage";
            this.pboFoodImage.Size = new System.Drawing.Size(116, 124);
            this.pboFoodImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboFoodImage.TabIndex = 71;
            this.pboFoodImage.TabStop = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(183, 94);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(79, 13);
            this.label21.TabIndex = 70;
            this.label21.Text = "Food Name: ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(183, 58);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 13);
            this.label20.TabIndex = 66;
            this.label20.Text = "Category: ";
            // 
            // dgvFoods
            // 
            this.dgvFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoods.Location = new System.Drawing.Point(14, 158);
            this.dgvFoods.Name = "dgvFoods";
            this.dgvFoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoods.Size = new System.Drawing.Size(524, 352);
            this.dgvFoods.TabIndex = 69;
            this.dgvFoods.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvFoods_KeyDown);
            // 
            // cboFoodName
            // 
            this.cboFoodName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFoodName.FormattingEnabled = true;
            this.cboFoodName.Location = new System.Drawing.Point(296, 86);
            this.cboFoodName.Name = "cboFoodName";
            this.cboFoodName.Size = new System.Drawing.Size(218, 21);
            this.cboFoodName.TabIndex = 67;
            this.cboFoodName.SelectedIndexChanged += new System.EventHandler(this.cboFoodName_SelectedIndexChanged);
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(296, 55);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(218, 21);
            this.cboCategory.TabIndex = 68;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // cboAddPorsion
            // 
            this.cboAddPorsion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAddPorsion.FormattingEnabled = true;
            this.cboAddPorsion.Location = new System.Drawing.Point(720, 200);
            this.cboAddPorsion.Name = "cboAddPorsion";
            this.cboAddPorsion.Size = new System.Drawing.Size(161, 21);
            this.cboAddPorsion.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(618, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Porsion: ";
            // 
            // lblPorsion
            // 
            this.lblPorsion.AutoSize = true;
            this.lblPorsion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPorsion.Location = new System.Drawing.Point(402, 127);
            this.lblPorsion.Name = "lblPorsion";
            this.lblPorsion.Size = new System.Drawing.Size(57, 13);
            this.lblPorsion.TabIndex = 60;
            this.lblPorsion.Text = "Porsion: ";
            // 
            // MealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 553);
            this.Controls.Add(this.cboAddPorsion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbMeals);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboAddCategory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnFoodAdd);
            this.Controls.Add(this.nudAddAmount);
            this.Controls.Add(this.nudAddCalorie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddImgePath);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAddFoodName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MealForm";
            this.Text = "MealForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudAddAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddCalorie)).EndInit();
            this.gbMeals.ResumeLayout(false);
            this.gbMeals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorsion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboFoodImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFoodAdd;
        private System.Windows.Forms.NumericUpDown nudAddAmount;
        private System.Windows.Forms.NumericUpDown nudAddCalorie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddImgePath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddFoodName;
        private System.Windows.Forms.ComboBox cboAddCategory;
        private System.Windows.Forms.GroupBox gbMeals;
        private System.Windows.Forms.NumericUpDown nudPorsion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pboFoodImage;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dgvFoods;
        private System.Windows.Forms.ComboBox cboFoodName;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblPorsion;
        private System.Windows.Forms.ComboBox cboAddPorsion;
        private System.Windows.Forms.Label label5;
    }
}