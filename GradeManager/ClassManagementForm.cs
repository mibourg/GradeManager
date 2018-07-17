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
    public partial class ClassManagementForm : Form
    {
        public ClassManagementForm()
        {
            InitializeComponent();
        }

        private void ClassManagementForm_Load(object sender, EventArgs e)
        {
            RefreshListBox();
        }

        private void addClassButton_Click(object sender, EventArgs e)
        {
            if (addClassTextBox.Text != "")
            {
                string className = addClassTextBox.Text;
                addClassTextBox.Clear();
                addClassTextBox.Select();
                Manager.Classes.Add(new Class(className, new List<Student>()));
                RefreshListBox();
            }
        }

        private void manageStudentsButton_Click(object sender, EventArgs e)
        {
            if (classesListBox.SelectedIndex >= 0)
            {
                Manager.ChosenClass = (Class)classesListBox.SelectedItem;
                StudentManagementForm studentManagementForm = new StudentManagementForm();
                this.Hide();
                studentManagementForm.Show();
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (classesListBox.SelectedIndex >= 0)
            {
                Manager.Classes.Remove((Class)classesListBox.SelectedItem);
                RefreshListBox();
            }
        }

        private void addClassTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addClassButton.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void RefreshListBox()
        {
            classesListBox.DataSource = null;
            classesListBox.DisplayMember = "Name";
            classesListBox.DataSource = Manager.Classes;
            classesListBox.Refresh();
        }
    }
}
