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
    public partial class RemoveBeverage : Form
    {
        public RemoveBeverage()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.ToString();

            if (name != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Project\mini_project\University_manage_system\RestaurantMiniProject\Restaurant.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                String query = "Delete from beverage where Name=@name";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Delete Successful");
                txtName.Text = "";
            }
            else
            {
                MessageBox.Show("Name must not be empty!");
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
