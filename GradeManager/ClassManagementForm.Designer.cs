namespace GradeManager
{
    partial class ClassManagementForm
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
            this.classesLabel = new System.Windows.Forms.Label();
            this.classesListBox = new System.Windows.Forms.ListBox();
            this.addClassButton = new System.Windows.Forms.Button();
            this.addClassTextBox = new System.Windows.Forms.TextBox();
            this.manageStudentsButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // classesLabel
            // 
            this.classesLabel.AutoSize = true;
            this.classesLabel.Location = new System.Drawing.Point(13, 13);
            this.classesLabel.Name = "classesLabel";
            this.classesLabel.Size = new System.Drawing.Size(46, 13);
            this.classesLabel.TabIndex = 0;
            this.classesLabel.Text = "Classes:";
            // 
            // classesListBox
            // 
            this.classesListBox.FormattingEnabled = true;
            this.classesListBox.Location = new System.Drawing.Point(16, 30);
            this.classesListBox.Name = "classesListBox";
            this.classesListBox.Size = new System.Drawing.Size(148, 277);
            this.classesListBox.TabIndex = 1;
            // 
            // addClassButton
            // 
            this.addClassButton.Location = new System.Drawing.Point(196, 56);
            this.addClassButton.Name = "addClassButton";
            this.addClassButton.Size = new System.Drawing.Size(75, 23);
            this.addClassButton.TabIndex = 2;
            this.addClassButton.Text = "Add Class";
            this.addClassButton.UseVisualStyleBackColor = true;
            this.addClassButton.Click += new System.EventHandler(this.addClassButton_Click);
            // 
            // addClassTextBox
            // 
            this.addClassTextBox.Location = new System.Drawing.Point(171, 30);
            this.addClassTextBox.Name = "addClassTextBox";
            this.addClassTextBox.Size = new System.Drawing.Size(100, 20);
            this.addClassTextBox.TabIndex = 3;
            this.addClassTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addClassTextBox_KeyDown);
            // 
            // manageStudentsButton
            // 
            this.manageStudentsButton.Location = new System.Drawing.Point(171, 283);
            this.manageStudentsButton.Name = "manageStudentsButton";
            this.manageStudentsButton.Size = new System.Drawing.Size(100, 23);
            this.manageStudentsButton.TabIndex = 4;
            this.manageStudentsButton.Text = "Manage Students";
            this.manageStudentsButton.UseVisualStyleBackColor = true;
            this.manageStudentsButton.Click += new System.EventHandler(this.manageStudentsButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(171, 85);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(100, 23);
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "Remove Selected";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // ClassManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 325);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.manageStudentsButton);
            this.Controls.Add(this.addClassTextBox);
            this.Controls.Add(this.addClassButton);
            this.Controls.Add(this.classesListBox);
            this.Controls.Add(this.classesLabel);
            this.Name = "ClassManagementForm";
            this.Text = "Manage Classes";
            this.Load += new System.EventHandler(this.ClassManagementForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label classesLabel;
        private System.Windows.Forms.ListBox classesListBox;
        private System.Windows.Forms.Button addClassButton;
        private System.Windows.Forms.TextBox addClassTextBox;
        private System.Windows.Forms.Button manageStudentsButton;
        private System.Windows.Forms.Button removeButton;
    }
}

