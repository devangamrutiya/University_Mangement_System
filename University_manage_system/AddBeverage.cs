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
    public partial class AddBeverage : Form
    {
        public AddBeverage()
        {
            InitializeComponent();
        }

        private void AddBeverage_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.ToString();
            string price = txtPrice.Text.ToString();
            string description = txtDescription.Text.ToString();

            if (name != "" && price != "" && description != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Project\mini_project\University_manage_system\RestaurantMiniProject\Restaurant.mdf;Integrated Security=True;Connect Timeout=30");
                String query = "insert into beverage values (@name,@price,@desc)";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", Convert.ToInt32(price));
                cmd.Parameters.AddWithValue("@desc", description);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Item Added Successfully...");
                txtName.Text = "";
                txtPrice.Text = "";
                txtDescription.Text = "";
            }
            else
            {
                MessageBox.Show("Fields must not be empty!");
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
