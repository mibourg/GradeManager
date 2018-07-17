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
    public partial class GradeManagementForm : Form
    {
        public GradeManagementForm()
        {
            InitializeComponent();
        }

        private void GradeManagementForm_Load(object sender, EventArgs e)
        {
            if (Manager.ChosenStudent.Assignments.Count > 0)
            {
                averageValueLabel.Text = Manager.ChosenStudent.CalculateAverage().ToString();
            }
            
            assignmentLabel.Text = Manager.ChosenStudent.Name + "'s assignments:";
            RefreshListBox();
        }

        private void addAssignmentButton_Click(object sender, EventArgs e)
        {
            if (assignmentNameTextBox.Text != "" && gradeTextBox.Text != "")
            {
                string assignmentName = assignmentNameTextBox.Text;
                int assignmentGrade = Convert.ToInt32(gradeTextBox.Text);
                Manager.ChosenStudent.Assignments.Add(new Assignment(assignmentName, assignmentGrade));

                assignmentNameTextBox.Clear();
                gradeTextBox.Clear();

                averageValueLabel.Text = Manager.ChosenStudent.CalculateAverage().ToString();

                RefreshListBox();
            }

        }

        private void GradeManagementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Manager.ChosenStudent = null;
            StudentManagementForm form = new StudentManagementForm();
            form.Show();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (assignmentsNameListBox.SelectedIndex >= 0)
            {
                Manager.ChosenStudent.Assignments.Remove((Assignment)assignmentsNameListBox.SelectedItem);

                averageValueLabel.Text = Manager.ChosenStudent.CalculateAverage().ToString();

                RefreshListBox();
            }
        }

        private void gradeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addAssignmentButton.PerformClick();
                assignmentNameTextBox.Select();
                e.SuppressKeyPress = true;
            }
        }

        private void assignmentNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gradeTextBox.Select();
                e.SuppressKeyPress = true;
            }
        }

        private void RefreshListBox()
        {
            assignmentsNameListBox.DataSource = null;
            assignmentsGradeListBox.DataSource = null;

            assignmentsNameListBox.DisplayMember = "Name";
            assignmentsNameListBox.DataSource = Manager.ChosenStudent.Assignments;
            assignmentsGradeListBox.DisplayMember = "Grade";
            assignmentsGradeListBox.DataSource = Manager.ChosenStudent.Assignments;
        }
    }
}
