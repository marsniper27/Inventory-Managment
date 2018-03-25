using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Month : Form
    {
        public int month { get; set; }
        public int year { get; set; }
        public Month()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {
            month = dateTimePicker1.Value.Month;
            year =  dateTimePicker1.Value.Year;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
