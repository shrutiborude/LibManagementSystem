using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
//using LibManagementSystem_Updated.Entities;
using LibManagementSystem_Updated.Models;


namespace LibManagementSystem_Updated
{
    public partial class StudentsForm : Form
    {
            private readonly DatabaseService<Student> _studentService;
            private Student selectedStudent; // Holds the selected student for Update/Delete

            public StudentsForm()
            {
                InitializeComponent();
                _studentService = new DatabaseService<Student>();
            }

            private void StudentsForm_Load(object sender, EventArgs e)
            {
                LoadStudentData();
            }

            private void LoadStudentData()
            {
                dataGridViewStudentForm.DataSource = _studentService.GetAll().ToList();
            }

            private void btnSave_Click(object sender, EventArgs e)
            {
                if (string.IsNullOrWhiteSpace(textBoxStudName.Text) || string.IsNullOrWhiteSpace(textBoxStudContact.Text) || string.IsNullOrWhiteSpace(textBoxStudContact.Text))
                {
                    MessageBox.Show("Please fill all fields.");
                    return;
                }

                var newStudent = new Student
                {
                    Name = textBoxStudName.Text,
                    StudentID = textBoxStudID.Text,
                    Contact = textBoxStudContact.Text
                };

                _studentService.Add(newStudent);
                MessageBox.Show("Student added successfully!");

                ClearForm();
                LoadStudentData();
            }

            private void btnUpdate_Click(object sender, EventArgs e)
            {
                if (selectedStudent == null)
                {
                    MessageBox.Show("Please select a student to update.");
                    return;
                }

                selectedStudent.Name = textBoxStudName.Text;
                selectedStudent.StudentID = textBoxStudID.Text;
                selectedStudent.Contact = textBoxStudContact.Text;

                _studentService.Update(selectedStudent);
                MessageBox.Show("Student updated successfully!");

                ClearForm();
                LoadStudentData();
            }

            private void btnDelete_Click(object sender, EventArgs e)
            {
                if (selectedStudent == null)
                {
                    MessageBox.Show("Please select a student to delete.");
                    return;
                }

                var confirm = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    _studentService.Delete(selectedStudent);
                    MessageBox.Show("Student deleted successfully!");

                    ClearForm();
                    LoadStudentData();
                }
            }

            private void dataGridViewStudentForm_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0)
                {
                    selectedStudent = dataGridViewStudentForm.Rows[e.RowIndex].DataBoundItem as Student;

                    if (selectedStudent != null)
                    {
                        textBoxStudName.Text = selectedStudent.Name;
                        textBoxStudID.Text = selectedStudent.StudentID;
                        textBoxStudContact.Text = selectedStudent.Contact;
                    }
                }
            }

            private void ClearForm()
            {
                textBoxStudName.Clear();
                textBoxStudID.Clear();
                textBoxStudContact.Clear();
                selectedStudent = null;
            }




        //public StudentsForm()
        //{
        //    InitializeComponent();
        //}

        //private void StudentsForm_Load(object sender, EventArgs e)
        //{

        //}

        //private void btnSave_Click(object sender, EventArgs e)
        //{

        //}

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{

        //}

        //private void btnDelete_Click(object sender, EventArgs e)
        //{

        //}

        //private void dataGridViewStudentForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
        }
    }
