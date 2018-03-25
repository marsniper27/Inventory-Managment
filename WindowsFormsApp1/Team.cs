using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Team : Form
    {
        public string team { get; set; }
        public string connection;
        public Team(string connetionString)
        {
            InitializeComponent();
            connection = connetionString;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            team = listBox1.SelectedValue.ToString();
        }

        private void Team_Load(object sender, EventArgs e)
        {
            DataSet Ds = new DataSet();
            SqlConnection cnn;
            cnn = new SqlConnection(connection);
            try
            {
                cnn.Open();
                SqlDataAdapter TeamAdapter = new SqlDataAdapter("SELECT * FROM Teams", cnn);
                TeamAdapter.Fill(Ds, "Teams");

                foreach(DataRow r in Ds.Tables["Teams"].Rows)
                { }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    } 
}
