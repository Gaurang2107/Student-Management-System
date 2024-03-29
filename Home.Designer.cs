namespace assignment_2_C_
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbStudent = new ListBox();
            groupBox1 = new GroupBox();
            rbUpdate = new RadioButton();
            rbAssignment = new RadioButton();
            rbDelete = new RadioButton();
            rbExit = new RadioButton();
            rbAdd = new RadioButton();
            label1 = new Label();
            txtTotal = new TextBox();
            txtMax = new TextBox();
            label2 = new Label();
            btnPerform = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbStudent
            // 
            lbStudent.FormattingEnabled = true;
            lbStudent.Location = new Point(113, 64);
            lbStudent.Name = "lbStudent";
            lbStudent.Size = new Size(407, 224);
            lbStudent.TabIndex = 0;
            lbStudent.SelectedIndexChanged += lbStudent_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbUpdate);
            groupBox1.Controls.Add(rbAssignment);
            groupBox1.Controls.Add(rbDelete);
            groupBox1.Controls.Add(rbExit);
            groupBox1.Controls.Add(rbAdd);
            groupBox1.Location = new Point(637, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(201, 225);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operations";
            // 
            // rbUpdate
            // 
            rbUpdate.AutoSize = true;
            rbUpdate.Location = new Point(39, 79);
            rbUpdate.Name = "rbUpdate";
            rbUpdate.Size = new Size(134, 24);
            rbUpdate.TabIndex = 4;
            rbUpdate.Text = "Update Student";
            rbUpdate.UseVisualStyleBackColor = true;
            // 
            // rbAssignment
            // 
            rbAssignment.AutoSize = true;
            rbAssignment.Location = new Point(39, 109);
            rbAssignment.Name = "rbAssignment";
            rbAssignment.Size = new Size(107, 24);
            rbAssignment.TabIndex = 3;
            rbAssignment.Text = "Assignment";
            rbAssignment.UseVisualStyleBackColor = true;
            // 
            // rbDelete
            // 
            rbDelete.AutoSize = true;
            rbDelete.Location = new Point(39, 139);
            rbDelete.Name = "rbDelete";
            rbDelete.Size = new Size(74, 24);
            rbDelete.TabIndex = 2;
            rbDelete.Text = "Delete";
            rbDelete.UseVisualStyleBackColor = true;
            // 
            // rbExit
            // 
            rbExit.AutoSize = true;
            rbExit.Checked = true;
            rbExit.Location = new Point(39, 169);
            rbExit.Name = "rbExit";
            rbExit.Size = new Size(54, 24);
            rbExit.TabIndex = 1;
            rbExit.TabStop = true;
            rbExit.Text = "Exit";
            rbExit.UseVisualStyleBackColor = true;
            // 
            // rbAdd
            // 
            rbAdd.AutoSize = true;
            rbAdd.Location = new Point(39, 49);
            rbAdd.Name = "rbAdd";
            rbAdd.Size = new Size(113, 24);
            rbAdd.TabIndex = 0;
            rbAdd.Text = "Add Student";
            rbAdd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(306, 336);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 2;
            label1.Text = "Total Score";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(395, 333);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 3;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(395, 377);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(125, 27);
            txtMax.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 380);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 4;
            label2.Text = "Maximim Score";
            // 
            // btnPerform
            // 
            btnPerform.Location = new Point(676, 371);
            btnPerform.Name = "btnPerform";
            btnPerform.Size = new Size(94, 29);
            btnPerform.TabIndex = 6;
            btnPerform.Text = "Perform";
            btnPerform.UseVisualStyleBackColor = true;
            btnPerform.Click += btnPerform_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 539);
            Controls.Add(btnPerform);
            Controls.Add(txtMax);
            Controls.Add(label2);
            Controls.Add(txtTotal);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(lbStudent);
            Name = "Home";
            Text = "Home";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbStudent;
        private GroupBox groupBox1;
        private RadioButton rbAssignment;
        private RadioButton rbDelete;
        private RadioButton rbExit;
        private RadioButton rbAdd;
        private Label label1;
        private TextBox txtTotal;
        private TextBox txtMax;
        private Label label2;
        private RadioButton rbUpdate;
        private Button btnPerform;
    }
}
