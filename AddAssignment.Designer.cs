namespace assignment_2_C_
{
    partial class AddAssignment
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
            lbAssignment = new ListBox();
            lblStudent = new Label();
            groupBox1 = new GroupBox();
            rbRemove = new RadioButton();
            rbFind = new RadioButton();
            rbUpdate = new RadioButton();
            rbAdd = new RadioButton();
            txtObtained = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            txtMaximum = new TextBox();
            label3 = new Label();
            gbDetails = new GroupBox();
            btnAdd = new Button();
            groupBox1.SuspendLayout();
            gbDetails.SuspendLayout();
            SuspendLayout();
            // 
            // lbAssignment
            // 
            lbAssignment.FormattingEnabled = true;
            lbAssignment.Location = new Point(12, 43);
            lbAssignment.Name = "lbAssignment";
            lbAssignment.Size = new Size(618, 304);
            lbAssignment.TabIndex = 0;
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Location = new Point(473, 9);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(50, 20);
            lblStudent.TabIndex = 1;
            lblStudent.Text = "label1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbRemove);
            groupBox1.Controls.Add(rbFind);
            groupBox1.Controls.Add(rbUpdate);
            groupBox1.Controls.Add(rbAdd);
            groupBox1.Location = new Point(714, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 184);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operations";
            // 
            // rbRemove
            // 
            rbRemove.AutoSize = true;
            rbRemove.Location = new Point(70, 133);
            rbRemove.Name = "rbRemove";
            rbRemove.Size = new Size(165, 24);
            rbRemove.TabIndex = 3;
            rbRemove.TabStop = true;
            rbRemove.Text = "Remove Assignment";
            rbRemove.UseVisualStyleBackColor = true;
            rbRemove.CheckedChanged += rbRemove_CheckedChanged;
            // 
            // rbFind
            // 
            rbFind.AutoSize = true;
            rbFind.Location = new Point(70, 103);
            rbFind.Name = "rbFind";
            rbFind.Size = new Size(139, 24);
            rbFind.TabIndex = 2;
            rbFind.TabStop = true;
            rbFind.Text = "Find Assignment";
            rbFind.UseVisualStyleBackColor = true;
            rbFind.CheckedChanged += rbFind_CheckedChanged;
            // 
            // rbUpdate
            // 
            rbUpdate.AutoSize = true;
            rbUpdate.Location = new Point(70, 73);
            rbUpdate.Name = "rbUpdate";
            rbUpdate.Size = new Size(160, 24);
            rbUpdate.TabIndex = 1;
            rbUpdate.Text = "Update Assignment";
            rbUpdate.UseVisualStyleBackColor = true;
            rbUpdate.CheckedChanged += rbUpdate_CheckedChanged;
            // 
            // rbAdd
            // 
            rbAdd.AutoSize = true;
            rbAdd.Checked = true;
            rbAdd.Location = new Point(70, 43);
            rbAdd.Name = "rbAdd";
            rbAdd.Size = new Size(139, 24);
            rbAdd.TabIndex = 0;
            rbAdd.TabStop = true;
            rbAdd.Text = "Add Assignment";
            rbAdd.UseVisualStyleBackColor = true;
            rbAdd.CheckedChanged += rbAdd_CheckedChanged;
            // 
            // txtObtained
            // 
            txtObtained.Location = new Point(167, 81);
            txtObtained.Name = "txtObtained";
            txtObtained.Size = new Size(125, 27);
            txtObtained.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 88);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 8;
            label2.Text = "Score Obtained";
            // 
            // txtID
            // 
            txtID.Location = new Point(167, 37);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 40);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 6;
            label1.Text = "Assignment ID";
            // 
            // txtMaximum
            // 
            txtMaximum.Location = new Point(167, 127);
            txtMaximum.Name = "txtMaximum";
            txtMaximum.Size = new Size(125, 27);
            txtMaximum.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 134);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 10;
            label3.Text = "Maximium Score";
            // 
            // gbDetails
            // 
            gbDetails.Controls.Add(btnAdd);
            gbDetails.Controls.Add(label1);
            gbDetails.Controls.Add(txtMaximum);
            gbDetails.Controls.Add(txtID);
            gbDetails.Controls.Add(label3);
            gbDetails.Controls.Add(label2);
            gbDetails.Controls.Add(txtObtained);
            gbDetails.Location = new Point(360, 398);
            gbDetails.Name = "gbDetails";
            gbDetails.Size = new Size(350, 220);
            gbDetails.TabIndex = 12;
            gbDetails.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(121, 177);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddAssignment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 711);
            Controls.Add(gbDetails);
            Controls.Add(groupBox1);
            Controls.Add(lblStudent);
            Controls.Add(lbAssignment);
            Name = "AddAssignment";
            Text = "AddAssignment";
            Load += AddAssignment_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbDetails.ResumeLayout(false);
            gbDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbAssignment;
        private Label lblStudent;
        private GroupBox groupBox1;
        private RadioButton rbRemove;
        private RadioButton rbFind;
        private RadioButton rbUpdate;
        private RadioButton rbAdd;
        private TextBox txtObtained;
        private Label label2;
        private TextBox txtID;
        private Label label1;
        private TextBox txtMaximum;
        private Label label3;
        private GroupBox gbDetails;
        private Button btnAdd;
    }
}