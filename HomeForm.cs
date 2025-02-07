using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibManagementSystem_Updated
{
    public partial class HomeForm : BaseForm
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            //OpenForm(new StudentsForm());
        }

        private void btnLibrarians_Click(object sender, EventArgs e)
        {
            //OpenForm(new LibrariansForm());
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            //OpenForm(new BooksForm());
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            // Any initialization logic here
        }
    }
}
