using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EisenhowerMatrix.view
{
    public partial class FormAdd : Form, IViewAdd
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            ConvertMass();
            this.Close();
        }

        public string[] ConvertMass() {
            string[] newDate = new string[3];

            if (checkBoxImp.Checked && checkBoxQui.Checked) {
                newDate[0] = "YY";
            }
            if (checkBoxImp.Checked) {
                newDate[0] = "YN";
            }
            if (checkBoxQui.Checked) {
                newDate[0] = "NY";
            }
            if (checkBoxImp.Checked == false && checkBoxQui.Checked == false) {
                newDate[0] = "NN";
            }

            newDate[1] = textBox1.Text;
            newDate[2] = richTextBox1.Text;

            return newDate;
        }
    }
}
