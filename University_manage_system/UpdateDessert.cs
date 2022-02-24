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
    public partial class UpdateDessert : Form
    {
        public UpdateDessert()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.ToString();
            string price = txtPrice.Text.ToString();
            string desc = txtDescription.Text.ToString();

            if (name != "" && price != "" && desc != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Project\mini_project\University_manage_system\RestaurantMiniProject\Restaurant.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                String query = "Update dessert Set Price=@price, Description=@desc where Name=@name";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@desc", desc);
                cmd.Parameters.AddWithValue("@price", Convert.ToInt32(price));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Update Successful");
                txtName.Text = "";
                txtPrice.Text = "";
                txtDescription.Text = "";
            }
            else
            {
                MessageBox.Show("Fields must not be empty!");
            }
        }

        private void btnCancleFood_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
