using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibTransportes.Entidades;

namespace PresentacionVehiculos
{
    public partial class PresentacionVehiculos : Form
    {
        public PresentacionVehiculos()
        {
            InitializeComponent();
        }
        private void MostrarCamion(object sender, EventArgs e)
        {
            var rem = new Remolque() { Estado = "Esta Conectado" };
            var cam = new Camion("Iveco", "Daily", 2000, "Piedra", 3000)
            {
                Remolque = rem
            };



            MessageBox.Show($"{cam}");
        }

        private void PresentacionVehiculos_Load(object sender, EventArgs e)
        {

        }
    }
}
