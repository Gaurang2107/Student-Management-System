namespace assignment_2_C_
{
    partial class AddStudent
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
            txtFirstName = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            txtTitle = new Label();
            btnAdd = new Button();
            txtLastName = new TextBox();
            label3 = new Label();
            txtAge = new TextBox();
            label4 = new Label();
            txtGender = new TextBox();
            label5 = new Label();
            txtClassName = new TextBox();
            label6 = new Label();
            txtGrade = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(390, 97);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 100);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 8;
            label2.Text = "First Name";
            // 
            // txtID
            // 
            txtID.Location = new Point(390, 64);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(301, 67);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 6;
            label1.Text = "StudentID";
            // 
            // txtTitle
            // 
            txtTitle.AutoSize = true;
            txtTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(352, 22);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(122, 28);
            txtTitle.TabIndex = 10;
            txtTitle.Text = "Add Student";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(380, 322);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(390, 130);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(305, 133);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 12;
            label3.Text = "Last Name";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(390, 163);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(125, 27);
            txtAge.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(348, 170);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 14;
            label4.Text = "Age";
            // 
            // txtGender
            // 
            txtGender.Location = new Point(390, 196);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(125, 27);
            txtGender.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(327, 199);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 16;
            label5.Text = "Gender";
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(390, 229);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(125, 27);
            txtClassName.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(298, 232);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 18;
            label6.Text = "Class Name";
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(390, 262);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(125, 27);
            txtGrade.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(335, 265);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 20;
            label7.Text = "Grade";
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtGrade);
            Controls.Add(label7);
            Controls.Add(txtClassName);
            Controls.Add(label6);
            Controls.Add(txtGender);
            Controls.Add(label5);
            Controls.Add(txtAge);
            Controls.Add(label4);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(btnAdd);
            Controls.Add(txtTitle);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(label1);
            Name = "AddStudent";
            Text = "AddStudent";
            Load += AddStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private Label label2;
        private TextBox txtID;
        private Label label1;
        private Label txtTitle;
        private Button btnAdd;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtAge;
        private Label label4;
        private TextBox txtGender;
        private Label label5;
        private TextBox txtClassName;
        private Label label6;
        private TextBox txtGrade;
        private Label label7;
    }
}