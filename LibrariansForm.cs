using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibManagementSystem_Updated.Models;

namespace LibManagementSystem_Updated
{
    public partial class LibrariansForm : Form
    {
        private readonly DatabaseService<Librarian> _librarianService;
        private Librarian selectedLibrarian; // Holds the selected student for Update/Delete

        public LibrariansForm()
        {
            InitializeComponent();
            _librarianService = new DatabaseService<Librarian>();
        }

        private void LibrariansForm_Load_1(object sender, EventArgs e)
        {
            LoadLibrarianData();
        }

        private void LoadLibrarianData()
        {
            dataGridViewLibrarianForm.DataSource = _librarianService.GetAll().ToList();
        }


        private void ClearForm()
        {
            textBoxLibName.Clear();
            textBoxLibID.Clear();
            textBoxLibContact.Clear();
            selectedLibrarian = null;
        }

        private void btnLibSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLibName.Text) || string.IsNullOrWhiteSpace(textBoxLibID.Text) || string.IsNullOrWhiteSpace(textBoxLibContact.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            var newLibrarian = new Librarian
            {
                Name = textBoxLibName.Text,
                EmployeeID = textBoxLibID.Text,
                Contact = textBoxLibContact.Text
            };

            _librarianService.Add(newLibrarian);
            MessageBox.Show("Student added successfully!");

            ClearForm();
            LoadLibrarianData();
        }

        private void btnLibUpdate_Click(object sender, EventArgs e)
        {
            if (selectedLibrarian == null)
            {
                MessageBox.Show("Please select a student to update.");
                return;
            }

            selectedLibrarian.Name = textBoxLibName.Text;
            selectedLibrarian.EmployeeID = textBoxLibID.Text;
            selectedLibrarian.Contact = textBoxLibContact.Text;

            _librarianService.Update(selectedLibrarian);
            MessageBox.Show("Student updated successfully!");

            ClearForm();
            LoadLibrarianData();
        }

        private void btnLibDelete_Click(object sender, EventArgs e)
        {
            if (selectedLibrarian == null)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                _librarianService.Delete(selectedLibrarian);
                MessageBox.Show("Student deleted successfully!");

                ClearForm();
                LoadLibrarianData();
            }
        }

        private void dataGridViewLibrarianForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedLibrarian = dataGridViewLibrarianForm.Rows[e.RowIndex].DataBoundItem as Librarian;

                if (selectedLibrarian != null)
                {
                    textBoxLibName.Text = selectedLibrarian.Name;
                    textBoxLibID.Text = selectedLibrarian.EmployeeID;
                    textBoxLibContact.Text = selectedLibrarian.Contact;
                }
            }
        }

        private void dataGridViewLibrarianForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                selectedLibrarian = dataGridViewLibrarianForm.Rows[e.RowIndex].DataBoundItem as Librarian;

                if (selectedLibrarian != null)
                {
                    textBoxLibName.Text = selectedLibrarian.Name;
                    textBoxLibID.Text = selectedLibrarian.EmployeeID;
                    textBoxLibContact.Text = selectedLibrarian.Contact;
                }
            }
        }
    }
}
