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
    public partial class Form1 : BaseForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm(new StudentsForm());
        }

        private void libbutton_Click(object sender, EventArgs e)
        {
            OpenForm(new LibrariansForm());
        }

        private void bookbutton_Click(object sender, EventArgs e)
        {
            OpenForm(new BooksForm());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
