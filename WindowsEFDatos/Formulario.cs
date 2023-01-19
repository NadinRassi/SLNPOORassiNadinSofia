using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFDatos.Data;
using WindowsEFDatos.Datos;
using WindowsEFDatos.Entities;

namespace WindowsEFDatos
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private readonly DbLineaAereaContext context = new DbLineaAereaContext();

        private void Formulario_Load(object sender, EventArgs e)
        {
            foreach (var item in context.LineasAereas)
            {
                comboLineas.Items.Add(item.Nombre);
            }
        }

        private void Insert(object sender, EventArgs e)
        {
            LineaAerea a = new LineaAerea();

            foreach (var item in context.LineasAereas)
            {
                if (comboLineas.Text == item.Nombre)
                {
                    a = item;
                }
            }

            Avion avion = new Avion()
            {
                Capacidad = (int)numCap.Value,
                Denominacion = txtDeno.Text,
                LineaAereaId = a.IdLinea
            };

            int rowsAffected = AbmAvion.Insertar(avion);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Insertado OK");
                //Refresh();
                numCap.ResetText();
                txtDeno.ResetText();
                comboLineas.ResetText();
            }                 
        }

        private void MostrarAviones(object sender, EventArgs e)
        {
            dataGridAv.DataSource = AbmAvion.Listar();
        }               

        private void Editar(object sender, EventArgs e)
        {
            LineaAerea a = new LineaAerea();            

            foreach (var item in context.LineasAereas)
            {
                if (comboLineas.Text == item.Nombre)
                {
                    a = item;
                }                
            }            

            Avion avion = new Avion()
            {
                IdAvion = int.Parse(txtID.Text),
                Capacidad = (int)numCap.Value,
                Denominacion = txtDeno.Text,
                LineaAereaId = a.IdLinea
            };

            int rowsAffected = AbmAvion.Editar(avion);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Editador OK");
                Refresh();

                txtID.ResetText();
                numCap.ResetText();
                txtDeno.ResetText();
                comboLineas.ResetText();
            }           
        }

        private void ListarUno(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);

            MessageBox.Show(AbmAvion.TraerUno(id).ToString());            
        }

        private void Eliminar(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            int rowsAffected = AbmAvion.Eliminar(id);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Eliminado OK");
                Refresh();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

         private void Refresh()//recargar
         {
             dataGridAv.DataSource = AbmAvion.Listar();
         }
    }
}
