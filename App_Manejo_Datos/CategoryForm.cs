using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Manejo_Datos
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            List<Category> categories = new List<Category>();

            using (SqlConnection connection = new SqlConnection("Server=MARS;Database=LP2;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                connection.Open();
                string query = "Select * From Categorias";

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Category category = new Category();
                    category.id = reader.GetInt32(0);
                    category.name = reader.GetString(1);

                    categories.Add(category);
                }

                screen.DataSource = categories;

            }

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(textInsertID.Text))
            {
                MessageBox.Show("Completar Campo ID");
                return;
            }

            if (string.IsNullOrEmpty(textInsertName.Text))
            {
                MessageBox.Show("Completar Campo Nombre");
                return;
            }


            using (SqlConnection connection = DB_Connection.OpenConnection())
            {                

                int ID = Convert.ToInt32(textInsertID.Text);
                string Name = textInsertName.Text;
                string query = "Insert Into Categorias (CategoriaID,NombreCategoria) Values (" + ID + ",'" + Name + "')";

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
                string query = "Delete From Categorias Where CategoriaID = " + ID;

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

            if (string.IsNullOrEmpty(textUpdateName.Text))
            {
                MessageBox.Show("Completar Campo Nombre");
                return;
            }

            using (SqlConnection connection = DB_Connection.OpenConnection())
            {
                int ID = Convert.ToInt32 (textUpdateID.Text);
 
                string query = $"Update Categorias Set NombreCategoria = '{textUpdateName.Text}' Where CategoriaID = {ID}";
                
                SqlCommand command = new SqlCommand(query, connection);

                int result = command.ExecuteNonQuery();

                if (result > 0) 
                {
                    MessageBox.Show("Exito al actualizar");
                }
                else
                {
                    MessageBox.Show("Error al actualizar");
                }

            }

        }
    }
}
