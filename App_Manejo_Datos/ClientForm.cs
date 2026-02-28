using Microsoft.Data.SqlClient;
using System;
using System.ClientModel.Primitives;
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
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            List<Client> lista = new List<Client>();

            using (SqlConnection connection = DB_Connection.OpenConnection())
            {
                string query = "Select * From Clientes";

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Client client = new Client();
                    client.id = reader.GetInt32(0);
                    client.name = reader.GetString(1);
                    client.mail = reader.GetString(2);
                    client.phone = reader.GetString(3);
                    client.address = reader.GetString(4);

                    lista.Add(client);
                }

                screen.DataSource = lista;
            }


        }
        //===
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textInsertID.Text))
            {
                MessageBox.Show("Completar Campo ID");
                return;
            }

            if (string.IsNullOrEmpty(textInsertName.Text))
            {
                MessageBox.Show("Completar Campo Nombre");
                return;
            }

            if (string.IsNullOrEmpty(textInsertMail.Text))
            {
                MessageBox.Show("Completar Campo Correo Electronico");
                return;
            }

            if (string.IsNullOrEmpty(textInsertPhone.Text)) 
            {
                MessageBox.Show("Completar Campo Telefono");
                return;
            }
            if (string.IsNullOrEmpty(textInsertAddress.Text))
            {
                MessageBox.Show("Completar Campo Direccion");
                return;
            }


            using (SqlConnection connetion = DB_Connection.OpenConnection())
            {

                int ID = Convert.ToInt32(textInsertID.Text);
                string name = textInsertName.Text;
                string mail = textInsertMail.Text;
                string phone = textInsertPhone.Text;
                string address = textInsertAddress.Text;

                string query = "Insert into Clientes (ClienteID,NombreCompleto,CorreoElectronico,Telefono,Direccion)" +
                    " Values (" + ID + ",'" + name + "','" + mail + "','" + phone + "','" + address + "')";

                SqlCommand command = new SqlCommand(query, connetion);

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

            using (SqlConnection connetion = DB_Connection.OpenConnection())
            {
                int ID = Convert.ToInt32(textDeleteID.Text);
                string query = "Delete From Clientes Where ClienteID = " + ID;
                SqlCommand sqlCommand = new SqlCommand(query, connetion);

                int result = sqlCommand.ExecuteNonQuery();

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

            if (string.IsNullOrEmpty(textUpdateMail.Text))
            {
                MessageBox.Show("Completar Campo Correo Electronico");
                return;
            }

            if (string.IsNullOrEmpty(textUpdatePhone.Text))
            {
                MessageBox.Show("Completar Campo Telefono");
                return;
            }
            if (string.IsNullOrEmpty(textUpdateAddress.Text))
            {
                MessageBox.Show("Completar Campo Direccion");
                return;
            }


            using (SqlConnection connection = DB_Connection.OpenConnection()) 
            {
                int ID = Convert.ToInt32(textUpdateID.Text);
                string name = textUpdateName.Text;
                string mail = textUpdateMail.Text;
                string phone = textUpdatePhone.Text;
                string address = textUpdateAddress.Text;

                string query = $"Update Clientes Set NombreCompleto = '{name}',CorreoElectronico = '{mail}',Telefono = '{phone}', Direccion = '{address}' Where ClienteID = '{ID}'";
                SqlCommand command = new SqlCommand(query,connection);

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
