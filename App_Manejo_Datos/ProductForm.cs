using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Manejo_Datos
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = DB_Connection.OpenConnection())
            {
                List<Product> products = new List<Product>();

                string query = "Select * From Productos";

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product();
                    product.id = reader.GetInt32(0);
                    product.name = reader.GetString(1);
                    product.description = reader.GetString(2);
                    product.price = reader.GetDecimal(3);
                    product.stock = reader.GetInt32(4);
                    product.category = reader.GetInt32(5);

                    products.Add(product);
                }

                screen.DataSource = products;
            }

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textInsertID.Text))
            {
                MessageBox.Show("Completar Campo ID");
                return;
            }

            if (string.IsNullOrEmpty(textInsertCategoria.Text))
            {
                MessageBox.Show("Completar Campo Categoria");
                return;
            }

            if (string.IsNullOrEmpty(textInsertName.Text))
            {
                MessageBox.Show("Completar Campo Nombre");
                return;
            }

            if (string.IsNullOrEmpty(textInsertPrice.Text))
            {
                MessageBox.Show("Completar Campo Precio");
                return;
            }

            if (string.IsNullOrEmpty(textInsertStock.Text))
            {
                MessageBox.Show("Completar Campo Stock");
                return;
            }

            if (string.IsNullOrEmpty(textInsertDescription.Text))
            {
                MessageBox.Show("Completar Campo Descripcion");
                return;
            }

            using (SqlConnection connection = DB_Connection.OpenConnection())
            {
                int ID = Convert.ToInt32(textInsertID.Text);
                string name = textInsertName.Text;
                string description = textInsertDescription.Text;
                decimal price = Convert.ToDecimal(textInsertPrice.Text);
                int Stock = Convert.ToInt32(textInsertStock.Text);
                int CategoryID = Convert.ToInt32(textInsertCategoria.Text);

                string query = "Insert Into Productos (ProductoID,NombreProducto,Descripcion,Precio,Stock,CategoriaID) " +
                    $"Values ({ID},'{name}','{description}',{price},{Stock},{CategoryID})";

                SqlCommand command = new SqlCommand(query, connection);

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Exito al Insertar");
                }
                else
                {
                    MessageBox.Show("Error al Insertar");
                }

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textDeleteID.Text))
            {
                MessageBox.Show("Completar Campo ID");
                return;
            }

            using (SqlConnection connection = DB_Connection.OpenConnection())
            {
                int ID = Convert.ToInt32(textDeleteID.Text);

                string query = $"Delete From Productos Where ProductoID = {ID}";

                SqlCommand command = new SqlCommand(query, connection);

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Exito al Eliminar");
                }
                else
                {
                    MessageBox.Show("Error al Eliminar");
                }

            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textUpdateID.Text))
            {
                MessageBox.Show("Completar Campo ID");
                return;
            }

            if (string.IsNullOrEmpty(textUpdateCategoria.Text))
            {
                MessageBox.Show("Completar Campo Categoria");
                return;
            }

            if (string.IsNullOrEmpty(textUpdateName.Text))
            {
                MessageBox.Show("Completar Campo Nombre");
                return;
            }

            if (string.IsNullOrEmpty(textUpdatePrice.Text))
            {
                MessageBox.Show("Completar Campo Precio");
                return;
            }

            if (string.IsNullOrEmpty(textUpdateStock.Text))
            {
                MessageBox.Show("Completar Campo Stock");
                return;
            }

            if (string.IsNullOrEmpty(textUpdateDescription.Text))
            {
                MessageBox.Show("Completar Campo Descripcion");
                return;
            }


            using (SqlConnection connection = DB_Connection.OpenConnection())
            {
                int ID = Convert.ToInt32(textUpdateID.Text);
                string name = textUpdateName.Text;
                string description = textUpdateDescription.Text;
                decimal price = Convert.ToDecimal (textUpdatePrice.Text);
                int stock = Convert.ToInt32(textUpdateStock.Text);
                int CategoryID = Convert.ToInt32(textUpdateCategoria.Text);

                string query = $"Update Productos Set NombreProducto = '{name}',Descripcion = '{description}',Precio = {price},Stock = {stock},CategoriaID = {CategoryID} Where ProductoID = {ID}";

                SqlCommand command = new SqlCommand(query, connection);

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Exito al Actualizar");
                }
                else
                {
                    MessageBox.Show("Error al Actualizar");
                }

            }

        }
    }
}
