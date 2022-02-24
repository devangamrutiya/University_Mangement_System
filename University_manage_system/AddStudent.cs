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

namespace RestaurantMiniProject
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnCancleFood_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string Fname = txtStudentName.Text.ToString();
            string enrollment = txtenrollment.Text.ToString();
            string address = txtAddress.Text.ToString();
            string city = txtcity.Text.ToString();
            string rollno = txtrollno.Text.ToString();

            if (Fname != "" && enrollment != "" && address!= "" && city!="" && rollno!="")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Project\mini_project\University_manage_system\RestaurantMiniProject\Restaurant.mdf;Integrated Security=True;Connect Timeout=30");
                String query = "insert into student values (@Fname,@enrollment,@address,@city,@rollno)";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.AddWithValue("@Fname", Fname);
                cmd.Parameters.AddWithValue("@rollno", Convert.ToInt32(rollno));
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@enrollment", enrollment);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Student Added Successfully...");
                txtStudentName.Text = "";
                txtenrollment.Text = "";
                txtAddress.Text = "";
            }
            else
            {
                MessageBox.Show("Fields must not be empty!");
            }
        }
    }
}
