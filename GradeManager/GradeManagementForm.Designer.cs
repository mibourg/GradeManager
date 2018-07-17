namespace GradeManager
{
    partial class GradeManagementForm
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
            this.assignmentNameTextBox = new System.Windows.Forms.TextBox();
            this.addAssignmentButton = new System.Windows.Forms.Button();
            this.assignmentsNameListBox = new System.Windows.Forms.ListBox();
            this.assignmentLabel = new System.Windows.Forms.Label();
            this.assignmentNameLabel = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.assignmentsGradeListBox = new System.Windows.Forms.ListBox();
            this.averageLabel = new System.Windows.Forms.Label();
            this.averageValueLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // assignmentNameTextBox
            // 
            this.assignmentNameTextBox.Location = new System.Drawing.Point(367, 25);
            this.assignmentNameTextBox.Name = "assignmentNameTextBox";
            this.assignmentNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.assignmentNameTextBox.TabIndex = 13;
            this.assignmentNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.assignmentNameTextBox_KeyDown);
            // 
            // addAssignmentButton
            // 
            this.addAssignmentButton.Location = new System.Drawing.Point(367, 77);
            this.addAssignmentButton.Name = "addAssignmentButton";
            this.addAssignmentButton.Size = new System.Drawing.Size(100, 23);
            this.addAssignmentButton.TabIndex = 12;
            this.addAssignmentButton.Text = "Add Assignment";
            this.addAssignmentButton.UseVisualStyleBackColor = true;
            this.addAssignmentButton.Click += new System.EventHandler(this.addAssignmentButton_Click);
            // 
            // assignmentsNameListBox
            // 
            this.assignmentsNameListBox.FormattingEnabled = true;
            this.assignmentsNameListBox.Location = new System.Drawing.Point(15, 25);
            this.assignmentsNameListBox.Name = "assignmentsNameListBox";
            this.assignmentsNameListBox.Size = new System.Drawing.Size(148, 277);
            this.assignmentsNameListBox.TabIndex = 11;
            // 
            // assignmentLabel
            // 
            this.assignmentLabel.AutoSize = true;
            this.assignmentLabel.Location = new System.Drawing.Point(12, 9);
            this.assignmentLabel.Name = "assignmentLabel";
            this.assignmentLabel.Size = new System.Drawing.Size(69, 13);
            this.assignmentLabel.TabIndex = 10;
            this.assignmentLabel.Text = "Assignments:";
            // 
            // assignmentNameLabel
            // 
            this.assignmentNameLabel.AutoSize = true;
            this.assignmentNameLabel.Location = new System.Drawing.Point(323, 28);
            this.assignmentNameLabel.Name = "assignmentNameLabel";
            this.assignmentNameLabel.Size = new System.Drawing.Size(38, 13);
            this.assignmentNameLabel.TabIndex = 14;
            this.assignmentNameLabel.Text = "Name:";
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Location = new System.Drawing.Point(322, 55);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(39, 13);
            this.gradeLabel.TabIndex = 15;
            this.gradeLabel.Text = "Grade:";
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.Location = new System.Drawing.Point(367, 52);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.Size = new System.Drawing.Size(100, 20);
            this.gradeTextBox.TabIndex = 16;
            this.gradeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gradeTextBox_KeyDown);
            // 
            // assignmentsGradeListBox
            // 
            this.assignmentsGradeListBox.FormattingEnabled = true;
            this.assignmentsGradeListBox.Location = new System.Drawing.Point(169, 25);
            this.assignmentsGradeListBox.Name = "assignmentsGradeListBox";
            this.assignmentsGradeListBox.Size = new System.Drawing.Size(148, 277);
            this.assignmentsGradeListBox.TabIndex = 17;
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Location = new System.Drawing.Point(320, 132);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(50, 13);
            this.averageLabel.TabIndex = 18;
            this.averageLabel.Text = "Average:";
            // 
            // averageValueLabel
            // 
            this.averageValueLabel.AutoSize = true;
            this.averageValueLabel.Location = new System.Drawing.Point(376, 132);
            this.averageValueLabel.Name = "averageValueLabel";
            this.averageValueLabel.Size = new System.Drawing.Size(0, 13);
            this.averageValueLabel.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Remove Selected";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // GradeManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 319);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.averageValueLabel);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.assignmentsGradeListBox);
            this.Controls.Add(this.gradeTextBox);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.assignmentNameLabel);
            this.Controls.Add(this.assignmentNameTextBox);
            this.Controls.Add(this.addAssignmentButton);
            this.Controls.Add(this.assignmentsNameListBox);
            this.Controls.Add(this.assignmentLabel);
            this.Name = "GradeManagementForm";
            this.Text = "GradeManagementForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GradeManagementForm_FormClosing);
            this.Load += new System.EventHandler(this.GradeManagementForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox assignmentNameTextBox;
        private System.Windows.Forms.Button addAssignmentButton;
        private System.Windows.Forms.ListBox assignmentsNameListBox;
        private System.Windows.Forms.Label assignmentLabel;
        private System.Windows.Forms.Label assignmentNameLabel;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.TextBox gradeTextBox;
        private System.Windows.Forms.ListBox assignmentsGradeListBox;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label averageValueLabel;
        private System.Windows.Forms.Button button1;
    }
}