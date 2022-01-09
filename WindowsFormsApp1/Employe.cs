using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Employe : Form
    {
        public Employe()
        {
            InitializeComponent();
        }


        String Coneclink = @"Data Source=DESKTOP-N781AR9\SQLEXPRESS;Initial Catalog=KMS;Integrated Security=True";

        
        SqlConnection conec;
        SqlCommand comand;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        



        public void Load_Data()
        {
            conec = new SqlConnection(Coneclink);
            conec.Open();
            comand = conec.CreateCommand();
            comand.CommandText = "Select * from Employee where status != N'Đã xóa' ";
            adapter.SelectCommand = comand;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
 
        }

        private void Employe_Load(object sender, EventArgs e)
        {
            conec = new SqlConnection(Coneclink);
            conec.Open();
            Load_Data();
            conec.Close();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if( CheckInput() == true )
            {
                conec = new SqlConnection(Coneclink);
                conec.Open();
                string sql = "insert into Employee(name, birthDay, identityCardNumber,status, age, post, salary) " +
                            "values (@name, @birthday, @ICN, @status, @age, @post, @salary) ";

                comand = new SqlCommand(sql, conec);
                comand.Parameters.AddWithValue("@name", txtName.Text);
                comand.Parameters.AddWithValue("@birthday", dtpBirthDay.Text);
                comand.Parameters.AddWithValue("@ICN", txtICN.Text);
                comand.Parameters.AddWithValue("@status", cbStatus.Text);
                long agee = DateTime.Now.Year - dtpBirthDay.Value.Year;
                comand.Parameters.AddWithValue("@age", agee);
                comand.Parameters.AddWithValue("@post", cbPosition.Text);
                long salaryy = long.Parse(txtSalary.Text);
                comand.Parameters.AddWithValue("@salary", salaryy );
                
                comand.ExecuteNonQuery();
                MessageBox.Show("Creadted", "Notification");
                txtName.Clear();
                txtICN.Clear();
                Load_Data();
            }

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            txtID.Text = dgv.Rows[i].Cells[0].Value.ToString();
            txtName.Text = dgv.Rows[i].Cells[1].Value.ToString();
            dtpBirthDay.Text = dgv.Rows[i].Cells[2].Value.ToString();
            txtICN.Text = dgv.Rows[i].Cells[3].Value.ToString();
            cbStatus.Text = dgv.Rows[i].Cells[6].Value.ToString();
            cbPosition.Text = dgv.Rows[i].Cells[8].Value.ToString();
            txtSalary.Text = dgv.Rows[i].Cells[9].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            conec = new SqlConnection(Coneclink);
            conec.Open();

            string list = "select id from employee";
            comand = new SqlCommand(list, conec);

            SqlDataReader sqlRead;
            sqlRead = comand.ExecuteReader();

            while (sqlRead.Read())
            {
                conec = new SqlConnection(Coneclink);
                conec.Open();

                if (sqlRead[0].ToString() == txtID.Text)
                {
                    conec = new SqlConnection(Coneclink);
                    conec.Open();

                    if (CheckInput() == true)
                    {
                        conec = new SqlConnection(Coneclink);
                        conec.Open();

                        string sql = "update Employee set name = @name, birthDay = @birthday, identityCardNumber = @ICN, post = @post, status = @status, age = @age, salary = @salary" +
                        " where id =" + txtID.Text;
                        comand = new SqlCommand(sql, conec);
                        comand.Parameters.AddWithValue("@name", txtName.Text);
                        comand.Parameters.AddWithValue("@birthday", dtpBirthDay.Text);
                        comand.Parameters.AddWithValue("@ICN", txtICN.Text);
                        comand.Parameters.AddWithValue("@post", cbPosition.Text);
                        comand.Parameters.AddWithValue("@status", cbStatus.Text);
                        long agee = DateTime.Now.Year - dtpBirthDay.Value.Year;
                        comand.Parameters.AddWithValue("@age", agee);
                        long salaryy = long.Parse(txtSalary.Text);
                        comand.Parameters.AddWithValue("@salary", salaryy);
                        comand.ExecuteNonQuery();
                        MessageBox.Show("Updated");
                        txtName.Clear();
                        txtICN.Clear();
                        Load_Data();
                        conec.Close();
                    }
                }
                

            }
            conec.Close();
        }

        public bool CheckInput()
        {
            if (txtName.Text != "" )
            {
                if (txtICN.Text != "" && txtICN.Text.Length == 9 )
                {
                    bool parseICN;
                    parseICN = int.TryParse(txtICN.Text, out int result);

                    if(parseICN == true)
                    {
                        if (cbPosition.Text != "")
                        {
                            if(cbStatus.Text != "")
                            {
                                if(txtSalary.Text != "" )
                                {
                                    bool parseSalary;
                                    parseSalary = long.TryParse(txtSalary.Text, out long resultS);

                                    if(parseSalary == true)
                                    {
                                        conec = new SqlConnection(Coneclink);
                                        conec.Open();

                                        string list = "select identityCardNumber, id, status from employee";
                                        comand = new SqlCommand(list, conec);

                                        SqlDataReader sqlRead;
                                        sqlRead = comand.ExecuteReader();

                                        while (sqlRead.Read())
                                        {
                                            if (sqlRead[0].ToString() == txtICN.Text && sqlRead[1].ToString() != txtID.Text && sqlRead[2].ToString() != "Đã xóa")
                                            {
                                                MessageBox.Show("Duplicate identity card number error", "Notification");
                                                conec.Close();
                                                return false;
                                            }

                                        }

                                        if (dtpBirthDay.Value.Year < 2003 && dtpBirthDay.Value.Year > 1970)
                                        {
                                            conec.Close();
                                            return true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Year of birth error", "Notification");
                                            conec.Close();
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Salary not entered", "Notification");
                                        conec.Close();
                                        return false;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Salary not entered", "Notification");
                                    conec.Close();
                                    return false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Satus not entered", "Notification");
                                conec.Close();
                                return false;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Position not entered", "Notification");
                            conec.Close();
                            return false;

                        }
                    }
                    else
                    {
                        MessageBox.Show("Identity card number not entered", "Notification");
                        conec.Close();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Identity card number error", "Notification");
                    conec.Close();
                    return false;

                }
            }
            else
            {
                MessageBox.Show("Name not entered", "Notification");
                conec.Close();
                return false;

            }
        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {

            conec = new SqlConnection(Coneclink);
            conec.Open();

            string list = "select id from employee";
            comand = new SqlCommand(list, conec);

            SqlDataReader sqlRead;
            sqlRead = comand.ExecuteReader();

            while (sqlRead.Read())
            {
                if (sqlRead[0].ToString() == txtID.Text)
                {
                    if (MessageBox.Show("Do you want to delete ?", "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        conec = new SqlConnection(Coneclink);
                        conec.Open();
                        string sql = "update Employee set status = N'Đã xóa', endDay=@end " +
                            " where id =" + txtID.Text;
                        comand = new SqlCommand(sql, conec);
                        comand.Parameters.AddWithValue("@end", DateTime.Now);

                        comand.ExecuteNonQuery();
                        MessageBox.Show("Deleted", "Notification");
                        Load_Data();
                        conec.Close();
                        return;
                        
                    }
                }
                
            }
            conec.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conec = new SqlConnection(Coneclink);
            conec.Open();
            comand = conec.CreateCommand();
            comand.CommandText = "Select * from Employee ";
            adapter.SelectCommand = comand;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
            conec.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Load_Data();
            conec.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if( txtSName.Text != "" )
            {
                conec = new SqlConnection(Coneclink);
                conec.Open();

                comand = conec.CreateCommand();
                comand.CommandText = "Select * from Employee where name LIKE N'%" + txtSName.Text + "%'";
                adapter.SelectCommand = comand;
                table.Clear();
                adapter.Fill(table);
                dgv.DataSource = table;
                conec.Close();
            }
            else
            {
                MessageBox.Show("Name search not entered", "Notification");
                conec.Close();
                return;
            }
        }

        private void btnSOBirthday_Click(object sender, EventArgs e)
        {           
                conec = new SqlConnection(Coneclink);
                conec.Open();

                comand = conec.CreateCommand();
                comand.CommandText = "Select * from Employee where birthDay = N'" + dtpSBirthday.Text + "'";
                adapter.SelectCommand = comand;
                table.Clear();
                adapter.Fill(table);
                dgv.DataSource = table;
                conec.Close();
           
        }

        private void btnSOICN_Click(object sender, EventArgs e)
        {
            bool parseSICN;
            parseSICN = int.TryParse(txtSICN.Text, out int result);
            if(parseSICN == true)
            {
                if (txtSICN.Text != "" && txtSICN.Text.Length == 9)
                {
                    conec = new SqlConnection(Coneclink);
                    conec.Open();

                    comand = conec.CreateCommand();
                    comand.CommandText = "Select * from Employee where identityCardNumber = " + txtSICN.Text;
                    adapter.SelectCommand = comand;
                    table.Clear();
                    adapter.Fill(table);
                    dgv.DataSource = table;
                    conec.Close();
                }
                else
                {
                    MessageBox.Show(" Identity card number search error", "Notification");
                    conec.Close();
                    return;
                }
            }
            else
            {
                MessageBox.Show(" Identity card number search error", "Notification");
                conec.Close();
                return;
            }
            
        }

        private void btnSOID_Click(object sender, EventArgs e)
        {
            bool parseSID;
            parseSID = int.TryParse(txtSID.Text, out int result);
            if (parseSID == true)
            {
                if (txtSID.Text != "")
                {
                    conec = new SqlConnection(Coneclink);
                    conec.Open();

                    comand = conec.CreateCommand();
                    comand.CommandText = "Select * from Employee where ID = N'" + txtSID.Text + "'";
                    adapter.SelectCommand = comand;
                    table.Clear();
                    adapter.Fill(table);
                    dgv.DataSource = table;
                    conec.Close();
                }
                else
                {
                    MessageBox.Show("ID search not entered", "Notification");
                    conec.Close();
                    return;
                }
            }
            else
            {
                MessageBox.Show(" ID search error", "Notification");
                conec.Close();
                return;
            }
        }

        private void btnSOStatus_Click(object sender, EventArgs e)
        {
            if (cbSStatus.Text != "")
            {
                conec = new SqlConnection(Coneclink);
                conec.Open();

                comand = conec.CreateCommand();
                comand.CommandText = "Select * from Employee where status = N'" + cbSStatus.Text + "'";
                adapter.SelectCommand = comand;
                table.Clear();
                adapter.Fill(table);
                dgv.DataSource = table;
                conec.Close();
            }
            else
            {
                MessageBox.Show("Status search not entered", "Notification");
                conec.Close();
                return;
            }
        }

        private void btnSOSalary_Click(object sender, EventArgs e)
        {
            bool parseSSalary;
            parseSSalary = int.TryParse(txtSSalary.Text, out int result);
            if (parseSSalary == true)
            {
                if (txtSSalary.Text != "")
                {
                    conec = new SqlConnection(Coneclink);
                    conec.Open();

                    comand = conec.CreateCommand();
                    comand.CommandText = "Select * from Employee where salary = N'" + txtSSalary.Text + "'";
                    adapter.SelectCommand = comand;
                    table.Clear();
                    adapter.Fill(table);
                    dgv.DataSource = table;
                    conec.Close();
                }
                else
                {
                    MessageBox.Show("Salary search not entered", "Notification");
                    conec.Close();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Salary search error", "Notification");
                conec.Close();
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSOPosition_Click(object sender, EventArgs e)
        {
            if (cbSPositon.Text != "" )
            {
                conec = new SqlConnection(Coneclink);
                conec.Open();

                comand = conec.CreateCommand();
                comand.CommandText = "Select * from Employee where post = N'" + cbSPositon.Text +"'";
                adapter.SelectCommand = comand;
                table.Clear();
                adapter.Fill(table);
                dgv.DataSource = table;
                conec.Close();
            }
            else
            {
                MessageBox.Show("Position not entered", "Notification");
                conec.Close();
                return;
            }
        }
    }

}
