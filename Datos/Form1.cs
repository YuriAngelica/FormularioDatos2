using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Datos
{
    public partial class Form1 : Form
    {
        DataTable tabla = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataColumn column;
            DataRow row;


            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Codigo";
            tabla.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Nombre";
            tabla.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Direccion";
            tabla.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.Decimal");
            column.ColumnName = "Telefono";
            tabla.Columns.Add(column);


            dtgDatos.DataSource = tabla;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            decimal telefono = decimal.Parse(txtTelefono.Text);


            DataRow newRow = tabla.NewRow();


            newRow["Codigo"] = codigo;
            newRow["Nombre"] = nombre;
            newRow["Direccion"] = direccion;
            newRow["Telefono"] = telefono;


            tabla.Rows.Add(newRow);

            dtgDatos.DataSource = tabla;


            txtCodigo.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();


        }
    }


        }
    

