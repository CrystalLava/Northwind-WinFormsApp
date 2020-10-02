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

namespace NorthwindLab3
{
    public partial class frmNorthwind : Form
    {
        public frmNorthwind()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
            
        {
            try
            {
                this.Validate();
                this.productsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.northwndDataSet);
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("A concurrency error occurred. " +
                    "Some rows were not updated.", "Concurrency Exception");
                this.productsTableAdapter.Fill(this.northwndDataSet.Products);
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                productsBindingSource.CancelEdit();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error # " + ex.Number +
                    ": " + ex.Message, ex.GetType().ToString());
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwndDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.northwndDataSet.Categories);
            // TODO: This line of code loads data into the 'northwndDataSet.Shippers' table. You can move, or remove it, as needed.
            this.shippersTableAdapter.Fill(this.northwndDataSet.Shippers);
            // TODO: This line of code loads data into the 'northwndDataSet.Order_Details' table. You can move, or remove it, as needed.
            this.order_DetailsTableAdapter.Fill(this.northwndDataSet.Order_Details);
            // TODO: This line of code loads data into the 'northwndDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.northwndDataSet.Products);
        }

        private void order_DetailsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            int row = e.RowIndex + 1;
            string errorMessage = "A data error occurred.\n" +
                "Row: " + row + "\n" +
                "Error: " + e.Exception.Message;
            MessageBox.Show(errorMessage, "Data Error");
        }
    }
}
