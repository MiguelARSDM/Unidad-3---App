using Microsoft.Data.SqlClient;
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
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            List<Supplier> suppliers = new List<Supplier>();

            using (SqlConnection connection = DB_Connection.OpenConnection())
            {
                string query = "Select * From Proveedores";

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Supplier supplier = new Supplier();
                    supplier.Id = reader.GetInt32(0);
                    supplier.Name = reader.GetString(1);
                    supplier.Phone = reader.GetString(2);
                    supplier.Mail = reader.GetString(3);

                    suppliers.Add(supplier);
                }

                screen.DataSource = suppliers;

            }

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = DB_Connection.OpenConnection())
            {

                int ID = Convert.ToInt32(textInsertID.Text);
                string name = textInsertName.Text;
                string phone = textInsertPhone.Text;
                string mail = textInsertMail.Text;

                string query = "Insert Into Proveedores (ProveedorID,ProveedorNombre,Telefono,CorreoElectronico)"
                    + $"Values ({ID},'{name}','{phone}','{mail}')";
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

            using (SqlConnection connection = DB_Connection.OpenConnection())
            {
                int ID = Convert.ToInt32(textDeleteID.Text);

                string query = $"Delete From Proveedores Where ProveedorID = {ID}";

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

            using (SqlConnection connection = DB_Connection.OpenConnection()) 
            { 
            
                int ID = Convert.ToInt32(textUpdateID.Text);
                string name = textUpdateName.Text;
                string phone = textUpdatePhone.Text;
                string mail = textUpdateMail.Text;

                string query = $"Update Proveedores Set ProveedorNombre = '{name}', Telefono = '{phone}', CorreoElectronico = '{mail}' Where ProveedorID = {ID}";

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
    }
}
