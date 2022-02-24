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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fetchData();
        }

        private void addFood_Click(object sender, EventArgs e)
        {
            new AddStudent().ShowDialog();
            fetchData();
        }

        private void updateFood_Click(object sender, EventArgs e)
        {
            new UpdateFood().ShowDialog();
            fetchData();
        }

        private void removeFood_Click(object sender, EventArgs e)
        {
            new RemoveFood().ShowDialog();
            fetchData();
        }

        private void addBeverage_Click(object sender, EventArgs e)
        {
            new AddBeverage().ShowDialog();
            fetchData();
        }

        private void updateBeverage_Click(object sender, EventArgs e)
        {
            new UpdateBeverage().ShowDialog();
            fetchData();
        }

        private void removeBeverage_Click(object sender, EventArgs e)
        {
            new RemoveBeverage().ShowDialog();
            fetchData();
        }

        private void addDessert_Click(object sender, EventArgs e)
        {
            new AddDessert().ShowDialog();
            fetchData();
        }

        private void updateDessert_Click(object sender, EventArgs e)
        {
            new UpdateDessert().ShowDialog();
            fetchData();
        }

        private void removeDessert_Click(object sender, EventArgs e)
        {
            new RemoveDessert().ShowDialog();
            fetchData();
        }

        private void about_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
            fetchData();
        }

        private void exitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fetchData()
        {
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Project\mini_project\University_manage_system\RestaurantMiniProject\Restaurant.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(conString);
            SqlDataAdapter da;
            DataSet ds;
            da = new SqlDataAdapter("SELECT * FROM student", con);
            ds = new DataSet();
            da.Fill(ds, "student");
            dataGridViewFood.DataSource = ds.Tables["student"].DefaultView;

            da = new SqlDataAdapter("SELECT * FROM beverage", con);
            ds = new DataSet();
            da.Fill(ds, "beverage");
            dataGridViewBeverage.DataSource = ds.Tables["beverage"].DefaultView;

            da = new SqlDataAdapter("SELECT * FROM dessert", con);
            ds = new DataSet();
            da.Fill(ds, "dessert");
            dataGridViewDessert.DataSource = ds.Tables["dessert"].DefaultView;
        }
    }
}
