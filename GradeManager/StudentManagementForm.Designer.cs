namespace GradeManager
{
    partial class StudentManagementForm
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
            this.manageGradesButton = new System.Windows.Forms.Button();
            this.addStudentTextBox = new System.Windows.Forms.TextBox();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.studentsListBox = new System.Windows.Forms.ListBox();
            this.studentLabel = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manageGradesButton
            // 
            this.manageGradesButton.Location = new System.Drawing.Point(169, 278);
            this.manageGradesButton.Name = "manageGradesButton";
            this.manageGradesButton.Size = new System.Drawing.Size(100, 23);
            this.manageGradesButton.TabIndex = 9;
            this.manageGradesButton.Text = "Manage Grades";
            this.manageGradesButton.UseVisualStyleBackColor = true;
            this.manageGradesButton.Click += new System.EventHandler(this.manageGradesButton_Click);
            // 
            // addStudentTextBox
            // 
            this.addStudentTextBox.Location = new System.Drawing.Point(169, 24);
            this.addStudentTextBox.Name = "addStudentTextBox";
            this.addStudentTextBox.Size = new System.Drawing.Size(100, 20);
            this.addStudentTextBox.TabIndex = 8;
            this.addStudentTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addStudentTextBox_KeyDown);
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(194, 50);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(75, 23);
            this.addStudentButton.TabIndex = 7;
            this.addStudentButton.Text = "Add Student";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // studentsListBox
            // 
            this.studentsListBox.FormattingEnabled = true;
            this.studentsListBox.Location = new System.Drawing.Point(15, 24);
            this.studentsListBox.Name = "studentsListBox";
            this.studentsListBox.Size = new System.Drawing.Size(148, 277);
            this.studentsListBox.TabIndex = 6;
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Location = new System.Drawing.Point(12, 9);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(52, 13);
            this.studentLabel.TabIndex = 5;
            this.studentLabel.Text = "Students:";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(169, 79);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(100, 23);
            this.removeButton.TabIndex = 10;
            this.removeButton.Text = "Remove Selected";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // StudentManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 315);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.manageGradesButton);
            this.Controls.Add(this.addStudentTextBox);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.studentsListBox);
            this.Controls.Add(this.studentLabel);
            this.Name = "StudentManagementForm";
            this.Text = "StudentManagementForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentManagementForm_FormClosing);
            this.Load += new System.EventHandler(this.StudentManagementForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button manageGradesButton;
        private System.Windows.Forms.TextBox addStudentTextBox;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.ListBox studentsListBox;
        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.Button removeButton;
    }
}