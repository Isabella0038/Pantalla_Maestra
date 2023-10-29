using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection.Emit;

namespace Pantalla_Maestra
{
    public partial class Form1 : Form
    {
        // Cadena de conexión para la base de datos
        string connectionString = "Data Source=ISABELLA\\SQLEXPRESS01;Database=Datos;Integrated Security=True";
        SqlConnection sqlConnection;
        SqlDataAdapter dataAdapter;
        DataSet dataSet;
        int position = 0;

        // Constructor de la clase
        public Form1()
        {
            InitializeComponent();
            // Inicializa la conexión a la base de datos y carga los datos en el formulario
            sqlConnection = new SqlConnection(connectionString);
            dataSet = new DataSet();
            GetData("SELECT Id, Nombre, Apellido, Contraseña, Telefono FROM Registros");
            DisplayData(position);
        }

        // Método para obtener datos de la base de datos
        private void GetData(string selectCommand)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    dataAdapter = new SqlDataAdapter(selectCommand, sqlConnection);
                    dataSet = new DataSet();
                    dataAdapter.Fill(dataSet, "Registros");
                    dataGridView1.DataSource = dataSet.Tables["Registros"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        // Método para mostrar los datos en los cuadros de texto
        private void DisplayData(int position)
        {
            DataTable dataTable = dataSet.Tables["Registros"];
            if (dataTable.Rows.Count > 0)
            {
                DataRow dataRow = dataTable.Rows[position];
                textBoxID.Text = dataRow["Id"].ToString();
                textBoxNombre.Text = dataRow["Nombre"].ToString();
                textBoxApellido.Text = dataRow["Apellido"].ToString();
                textBoxContraseña.Text = dataRow["Contraseña"].ToString();
                textBoxTelefono.Text = dataRow["Telefono"].ToString();
                label1.Text = "Registros " + (position + 1) + " de " + dataTable.Rows.Count;
            }
        }

        // Botón para limpiar los cuadros de texto para ingresar un nuevo registro
        private void BtnNuevoRegistr(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxContraseña.Text = "";
            textBoxTelefono.Text = "";
        }

        // Botón para guardar un nuevo registro en la base de datos
        private void BtnGuardarRegistr(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter))
                {
                    DataRow dataRow = dataSet.Tables["Registros"].NewRow();
                    dataRow["Id"] = textBoxID.Text;
                    dataRow["Nombre"] = textBoxNombre.Text;
                    dataRow["Apellido"] = textBoxApellido.Text;
                    dataRow["Contraseña"] = textBoxContraseña.Text;
                    dataRow["Telefono"] = textBoxTelefono.Text;

                    dataSet.Tables["Registros"].Rows.Add(dataRow);
                    dataAdapter.Update(dataSet, "Registros");
                }
                GetData("SELECT * FROM Registros");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }
        }

        // Botón para actualizar un registro existente en la base de datos
        private void BtnActualizarRegistr(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;
                    DataRow selectedDataRow = dataSet.Tables["Registros"].Rows[selectedIndex];
                    selectedDataRow["Id"] = textBoxID.Text;
                    selectedDataRow["Nombre"] = textBoxNombre.Text;
                    selectedDataRow["Apellido"] = textBoxApellido.Text;
                    selectedDataRow["Contraseña"] = textBoxContraseña.Text;
                    selectedDataRow["Telefono"] = textBoxTelefono.Text;

                    using (SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter))
                    {
                        dataAdapter.Update(dataSet, "Registros");
                    }
                    GetData("SELECT * FROM Registros");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar los datos: " + ex.Message);
                }
            }
        }

        // Botón para eliminar un registro de la base de datos
        private void BtnEliminarRegistr(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;
                    dataSet.Tables["Registros"].Rows[selectedIndex].Delete();
                    using (SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter))
                    {
                        dataAdapter.Update(dataSet, "Registros");
                    }
                    GetData("SELECT * FROM Registros");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar los datos: " + ex.Message);
                }
            }
        }

        // Botón para ir al primer registro en la base de datos
        private void BtnPrimerRegistr(object sender, EventArgs e)
        {
            position = 0;
            DisplayData(position);
        }

        // Botón para ir al registro anterior en la base de datos
        private void BtnAnteriorRegistr(object sender, EventArgs e)
        {
            if (position > 0)
            {
                position--;
                DisplayData(position);
            }
        }

        // Botón para ir al siguiente registro en la base de datos
        private void BtnSiguienteRegistr(object sender, EventArgs e)
        {
            DataTable dataTable = dataSet.Tables["Registros"];
            if (position < dataTable.Rows.Count - 1)
            {
                position++;
                DisplayData(position);
            }
        }

        // Botón para ir al último registro en la base de datos
        private void BtnUltimoRegistr(object sender, EventArgs e)
        {
            DataTable dataTable = dataSet.Tables["Registros"];
            if (dataTable.Rows.Count > 0)
            {
                position = dataTable.Rows.Count - 1;
                DisplayData(position);
            }
        }

        // Método para manejar errores de datos en el DataGridView
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Maneja el error de datos y evita que la excepción detenga la aplicación.
            MessageBox.Show("Error de datos en el DataGridView: " + e.Exception.Message);
        }
    }
}
