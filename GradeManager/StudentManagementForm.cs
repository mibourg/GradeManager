using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeManager
{
    public partial class StudentManagementForm : Form
    {
        public StudentManagementForm()
        {
            InitializeComponent();
        }

        private void StudentManagementForm_Load(object sender, EventArgs e)
        {
            studentLabel.Text = "Students in " + Manager.ChosenClass.Name + ":";
            RefreshListBox();
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            if (addStudentTextBox.Text != "")
            {
                Manager.ChosenClass.Students.Add(new Student(addStudentTextBox.Text));
                addStudentTextBox.Clear();
                RefreshListBox();
            }
        }

        private void manageGradesButton_Click(object sender, EventArgs e)
        {
            if (studentsListBox.SelectedIndex >= 0)
            {
                Manager.ChosenStudent = (Student)studentsListBox.SelectedItem;
                this.Hide();
                GradeManagementForm gradeManagementForm = new GradeManagementForm();
                gradeManagementForm.Show();
            }
        }

        private void StudentManagementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Manager.ChosenClass = null;
            ClassManagementForm form = new ClassManagementForm();
            form.Show();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (studentsListBox.SelectedIndex >= 0)
            {
                Manager.ChosenClass.Students.Remove((Student)studentsListBox.SelectedItem);
                RefreshListBox();
            }
        }

        private void addStudentTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addStudentButton.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void RefreshListBox()
        {
            studentsListBox.DataSource = null;
            studentsListBox.DisplayMember = "Name";
            studentsListBox.DataSource = Manager.ChosenClass.Students;
            studentsListBox.Refresh();
        }
    }
}
