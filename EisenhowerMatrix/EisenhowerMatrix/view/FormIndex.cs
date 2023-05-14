using EisenhowerMatrix.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EisenhowerMatrix
{
    public partial class FormIndex : Form
    {

        List<string[]> ListCaseMain;

        public FormIndex()
        {
            InitializeComponent();
            checkBoxImportant.Checked = false;
            checkBoxQuick.Checked = false;
            checkBoxImportant.Enabled = false;
            checkBoxQuick.Enabled = false;
        }

        private void labelLabel_Click(object sender, EventArgs e)
        {
            const string LINK = "https://github.com/Helltale";
            System.Diagnostics.Process.Start(LINK);
        }

        void ShowChildForm(Form form)
        {
            form.MdiParent = this;
            form.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public event EventHandler AddCaseEvent;
        public event EventHandler RemoveCaseEvent;

        


        private void buttonCaseAdd_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd();
            formAdd.Show();
        }

        private void buttonCaseClose_Click(object sender, EventArgs e)
        {

        }

        private void buttonCaseHeaven_Click(object sender, EventArgs e)
        {

        }

        
    }
}
