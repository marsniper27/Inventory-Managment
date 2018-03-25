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
    public partial class Form1 : Form
    {
        public string connetionString = "Data Source=192.168.2.18,1433;Network Library=DBMSSOCN;Initial Catalog=InventorySystem;User ID=sa;Password=Jac0bI2aac1!";
        public DataSet Inventory = new DataSet();
        public DataTable Report = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);
            try
            {

                cnn.Open();
                SqlDataAdapter TeamAdapter = new SqlDataAdapter("SELECT * FROM Teams", cnn);
                SqlDataAdapter MachineAdapter = new SqlDataAdapter("SELECT * FROM Machines", cnn);
                SqlDataAdapter EmployeeAdapter = new SqlDataAdapter("SELECT * FROM Employees", cnn);
                SqlDataAdapter EquipmentAdapter = new SqlDataAdapter("SELECT * FROM Equipment", cnn);
                SqlDataAdapter InUseEquipmentAdapter = new SqlDataAdapter("SELECT * FROM InUseEquipment", cnn);
                InUseEquipmentAdapter.Fill(Inventory, "InUseEquipment");
                TeamAdapter.Fill(Inventory, "Teams");
                MachineAdapter.Fill(Inventory, "Machines");
                EmployeeAdapter.Fill(Inventory, "Employees");
                EquipmentAdapter.Fill(Inventory, "Equipment");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void SaveReport_Click(object sender, EventArgs e)
        {

        }

        private void Monthly_Click(object sender, EventArgs e)
        {
            Report = null;
            DataSet DS = new DataSet();
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);
            using (var form = new Month())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int month = form.month;     //values preserved after close
                    int year = form.year;

                    try
                    {
                        cnn.Open();
                        SqlDataAdapter InUseEquipmentAdapter = new SqlDataAdapter("SELECT * FROM InUseEquipment Where MONTH([Date Out]) = @Month AND Year([Date Out]) = @Year", cnn);
                        InUseEquipmentAdapter.SelectCommand.Parameters.AddWithValue("@Month",month);
                        InUseEquipmentAdapter.SelectCommand.Parameters.AddWithValue("@Year", year);
                        InUseEquipmentAdapter.Fill(DS, "InUseEquipment");

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }

            dataGridView1.DataSource = DS.Tables["InUseEquipment"];
        }

        private void Weekly_Click(object sender, EventArgs e)
        {
            Report = null;
            DataSet DS = new DataSet();
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);
            using (var form = new Weekly())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int day = form.day;
                    int endday = day + 6;
                    int month = form.month;     //values preserved after close
                    int year = form.year;

                    try
                    {
                        cnn.Open();
                        SqlDataAdapter InUseEquipmentAdapter = new SqlDataAdapter("SELECT * FROM InUseEquipment Where DAY([Date Out]) BETWEEN  @Day AND @EndDay AND MONTH([Date Out]) = @Month AND Year([Date Out]) = @Year", cnn);
                        InUseEquipmentAdapter.SelectCommand.Parameters.AddWithValue("@EndDay", endday);
                        InUseEquipmentAdapter.SelectCommand.Parameters.AddWithValue("@Day", day);
                        InUseEquipmentAdapter.SelectCommand.Parameters.AddWithValue("@Month", month);
                        InUseEquipmentAdapter.SelectCommand.Parameters.AddWithValue("@Year", year);
                        InUseEquipmentAdapter.Fill(DS, "InUseEquipment");

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }

            dataGridView1.DataSource = DS.Tables["InUseEquipment"];
        }

        private void TwoWeeks_Click(object sender, EventArgs e)
        {
            Report = null;
            DataSet DS = new DataSet();
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);
            DateTime day = DateTime.Now.AddDays(-13);

            try
            {
                cnn.Open();
                SqlDataAdapter InUseEquipmentAdapter = new SqlDataAdapter("SELECT * FROM InUseEquipment Where [Date IN] IS NULL AND [Date Out] < @Day ", cnn);
                InUseEquipmentAdapter.SelectCommand.Parameters.AddWithValue("@Day", day);
                InUseEquipmentAdapter.Fill(DS, "InUseEquipment");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            dataGridView1.DataSource = DS.Tables["InUseEquipment"];
        }

        private void DownEquipment_click(object sender, EventArgs e)
        {
            Report = null;
            DataSet DS = new DataSet();
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);
             try
             {
                 cnn.Open();
                 SqlDataAdapter EquipmentAdapter = new SqlDataAdapter("SELECT * FROM Equipment Where Status = @status", cnn);
                 EquipmentAdapter.SelectCommand.Parameters.AddWithValue("@Status", "Down");
                 EquipmentAdapter.Fill(DS, "Equipment");
             }
             catch (Exception ex)
             {
                Console.WriteLine(ex.ToString());
             }
             
            dataGridView1.DataSource = DS.Tables["Equipment"];
            Report = DS.Tables["Equipment"];        }

        private void OutByTeam_click(object sender, EventArgs e)
        {
            Report = null;
            DataSet DS = new DataSet();
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);
            using (var form = new Team(connetionString))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string team = form.team;     //values preserved after close

                    try
                    {
                        cnn.Open();
                        SqlDataAdapter InUseEquipmentAdapter = new SqlDataAdapter("SELECT * FROM InUseEquipment JOIN Employees ON Equipment.Employee = Employees.ID Where InUseEquipment.[Date IN] IS NULL AND Employees.Team = @Team", cnn);
                        InUseEquipmentAdapter.SelectCommand.Parameters.AddWithValue("@Team", team);
                        InUseEquipmentAdapter.Fill(DS, "InUseEquipment");

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }

            dataGridView1.DataSource = DS.Tables["InUseEquipment"];
        }

        private void SubmitEmployee_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();

                SqlCommand EmployeeUpdate = new SqlCommand();
                EmployeeUpdate.Connection = cnn;
                EmployeeUpdate.CommandText = "INSERT INTO  Employees (FirstName,LastName,Team,Role,[ID Card]) Values(@FirstName,@LastName,@Team,@Role,@IDCard)";
                EmployeeUpdate.Parameters.AddWithValue("@FirstName", FirstNameTextBox.Text);
                EmployeeUpdate.Parameters.AddWithValue("@LastName", LastNameTextBox.Text);
                EmployeeUpdate.Parameters.AddWithValue("@Team", TeamListBox.GetItemText(TeamListBox.SelectedItem));
                EmployeeUpdate.Parameters.AddWithValue("@Role", RoleListBox.GetItemText(RoleListBox.SelectedItem));
                EmployeeUpdate.Parameters.AddWithValue("@IDCard", int.Parse(IDCardTextBox.Text));
                EmployeeUpdate.ExecuteNonQuery();
                MessageBox.Show($"Employee: {FirstNameTextBox.Text} {LastNameTextBox.Text}\n" +
                                $"Team: {TeamListBox.SelectedItem.ToString()}\n" +
                                $"Role: {RoleListBox.SelectedItem.ToString()}\n" +
                                $"ID Card: {IDCardTextBox.Text}\n" +
                                "Has Been added to the database");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
