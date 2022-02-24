namespace RestaurantMiniProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.foodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFood = new System.Windows.Forms.ToolStripMenuItem();
            this.updateFood = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFood = new System.Windows.Forms.ToolStripMenuItem();
            this.beverageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBeverage = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBeverage = new System.Windows.Forms.ToolStripMenuItem();
            this.removeBeverage = new System.Windows.Forms.ToolStripMenuItem();
            this.dessertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDessert = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDessert = new System.Windows.Forms.ToolStripMenuItem();
            this.removeDessert = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.exitForm = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewFood = new System.Windows.Forms.DataGridView();
            this.dataGridViewBeverage = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewDessert = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBeverage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDessert)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foodToolStripMenuItem,
            this.beverageToolStripMenuItem,
            this.dessertToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // foodToolStripMenuItem
            // 
            this.foodToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFood,
            this.updateFood,
            this.removeFood});
            this.foodToolStripMenuItem.Name = "foodToolStripMenuItem";
            this.foodToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.foodToolStripMenuItem.Text = "Student";
            // 
            // addFood
            // 
            this.addFood.Name = "addFood";
            this.addFood.Size = new System.Drawing.Size(180, 22);
            this.addFood.Text = "Add Student";
            this.addFood.Click += new System.EventHandler(this.addFood_Click);
            // 
            // updateFood
            // 
            this.updateFood.Name = "updateFood";
            this.updateFood.Size = new System.Drawing.Size(180, 22);
            this.updateFood.Text = "Update Student";
            this.updateFood.Click += new System.EventHandler(this.updateFood_Click);
            // 
            // removeFood
            // 
            this.removeFood.Name = "removeFood";
            this.removeFood.Size = new System.Drawing.Size(180, 22);
            this.removeFood.Text = "Remove Student";
            this.removeFood.Click += new System.EventHandler(this.removeFood_Click);
            // 
            // beverageToolStripMenuItem
            // 
            this.beverageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBeverage,
            this.updateBeverage,
            this.removeBeverage});
            this.beverageToolStripMenuItem.Name = "beverageToolStripMenuItem";
            this.beverageToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.beverageToolStripMenuItem.Text = "Beverage";
            // 
            // addBeverage
            // 
            this.addBeverage.Name = "addBeverage";
            this.addBeverage.Size = new System.Drawing.Size(180, 22);
            this.addBeverage.Text = "Add New Beverage";
            this.addBeverage.Click += new System.EventHandler(this.addBeverage_Click);
            // 
            // updateBeverage
            // 
            this.updateBeverage.Name = "updateBeverage";
            this.updateBeverage.Size = new System.Drawing.Size(180, 22);
            this.updateBeverage.Text = "Update Item";
            this.updateBeverage.Click += new System.EventHandler(this.updateBeverage_Click);
            // 
            // removeBeverage
            // 
            this.removeBeverage.Name = "removeBeverage";
            this.removeBeverage.Size = new System.Drawing.Size(180, 22);
            this.removeBeverage.Text = "Remove Item";
            this.removeBeverage.Click += new System.EventHandler(this.removeBeverage_Click);
            // 
            // dessertToolStripMenuItem
            // 
            this.dessertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDessert,
            this.updateDessert,
            this.removeDessert});
            this.dessertToolStripMenuItem.Name = "dessertToolStripMenuItem";
            this.dessertToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.dessertToolStripMenuItem.Text = "Dessert";
            // 
            // addDessert
            // 
            this.addDessert.Name = "addDessert";
            this.addDessert.Size = new System.Drawing.Size(180, 22);
            this.addDessert.Text = "Add New Dessert";
            this.addDessert.Click += new System.EventHandler(this.addDessert_Click);
            // 
            // updateDessert
            // 
            this.updateDessert.Name = "updateDessert";
            this.updateDessert.Size = new System.Drawing.Size(180, 22);
            this.updateDessert.Text = "Update Item";
            this.updateDessert.Click += new System.EventHandler(this.updateDessert_Click);
            // 
            // removeDessert
            // 
            this.removeDessert.Name = "removeDessert";
            this.removeDessert.Size = new System.Drawing.Size(180, 22);
            this.removeDessert.Text = "Remove Item";
            this.removeDessert.Click += new System.EventHandler(this.removeDessert_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about,
            this.exitForm});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(180, 22);
            this.about.Text = "About";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // exitForm
            // 
            this.exitForm.Name = "exitForm";
            this.exitForm.Size = new System.Drawing.Size(180, 22);
            this.exitForm.Text = "Exit";
            this.exitForm.Click += new System.EventHandler(this.exitForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(72, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Food";
            // 
            // dataGridViewFood
            // 
            this.dataGridViewFood.AllowUserToAddRows = false;
            this.dataGridViewFood.AllowUserToDeleteRows = false;
            this.dataGridViewFood.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewFood.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewFood.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewFood.Location = new System.Drawing.Point(0, 77);
            this.dataGridViewFood.Name = "dataGridViewFood";
            this.dataGridViewFood.ReadOnly = true;
            this.dataGridViewFood.RowTemplate.ReadOnly = true;
            this.dataGridViewFood.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFood.Size = new System.Drawing.Size(500, 411);
            this.dataGridViewFood.TabIndex = 3;
            // 
            // dataGridViewBeverage
            // 
            this.dataGridViewBeverage.AllowUserToAddRows = false;
            this.dataGridViewBeverage.AllowUserToDeleteRows = false;
            this.dataGridViewBeverage.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewBeverage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewBeverage.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewBeverage.Location = new System.Drawing.Point(506, 77);
            this.dataGridViewBeverage.Name = "dataGridViewBeverage";
            this.dataGridViewBeverage.ReadOnly = true;
            this.dataGridViewBeverage.RowTemplate.ReadOnly = true;
            this.dataGridViewBeverage.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBeverage.Size = new System.Drawing.Size(343, 503);
            this.dataGridViewBeverage.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(502, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Beverage";
            // 
            // dataGridViewDessert
            // 
            this.dataGridViewDessert.AllowUserToAddRows = false;
            this.dataGridViewDessert.AllowUserToDeleteRows = false;
            this.dataGridViewDessert.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewDessert.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDessert.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewDessert.Location = new System.Drawing.Point(950, 77);
            this.dataGridViewDessert.Name = "dataGridViewDessert";
            this.dataGridViewDessert.ReadOnly = true;
            this.dataGridViewDessert.RowTemplate.ReadOnly = true;
            this.dataGridViewDessert.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDessert.Size = new System.Drawing.Size(343, 503);
            this.dataGridViewDessert.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(946, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dessert";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 640);
            this.Controls.Add(this.dataGridViewDessert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewBeverage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewFood);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBeverage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDessert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem foodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFood;
        private System.Windows.Forms.ToolStripMenuItem updateFood;
        private System.Windows.Forms.ToolStripMenuItem removeFood;
        private System.Windows.Forms.ToolStripMenuItem beverageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBeverage;
        private System.Windows.Forms.ToolStripMenuItem updateBeverage;
        private System.Windows.Forms.ToolStripMenuItem removeBeverage;
        private System.Windows.Forms.ToolStripMenuItem dessertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDessert;
        private System.Windows.Forms.ToolStripMenuItem updateDessert;
        private System.Windows.Forms.ToolStripMenuItem removeDessert;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.ToolStripMenuItem exitForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewFood;
        private System.Windows.Forms.DataGridView dataGridViewBeverage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewDessert;
        private System.Windows.Forms.Label label3;
    }
}

