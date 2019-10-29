using ModelosRally;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistasRally
{
    public partial class Form1 : Form
    {
        public event EventHandler<AgregarPilotoEventArgs> OnAgregarPiloto;
        public event EventHandler<AgregarNaveganteEventArgs> OnAgregarNavegante;
        public event EventHandler<AgregarEquipoEventArgs> OnAgregarEquipo;


        public Form1()
        {
            InitializeComponent();
        }

        private void AgregarPilotoButton_Click(object sender, EventArgs e)
        {
            if (OnAgregarPiloto != null)
            {
                AgregarPilotoEventArgs pilotoArgs = new AgregarPilotoEventArgs();
                pilotoArgs.nombre = this.NameTextBox.Text;
                OnAgregarPiloto(this, pilotoArgs);
            }
               
        }

        public void ActualizarListadoPilotos(Persona pilotoNuevo)
        {
            PilotNameComboBox.Items.Add(pilotoNuevo);
            PilotoCB.Items.Add(pilotoNuevo);
        }

        public void ActualizarListadoNavegantes(Persona naveganteNuevo)
        {
            PilotNameComboBox.Items.Add(naveganteNuevo);
            NaveganteCB.Items.Add(naveganteNuevo);
        }

        public void ActualizarListadoEquipos(string nombre, string marcaVehiculo, string ccVehiculo, string piloto, string navegante)
        {
            TeamNameComboBox.Items.Add($"{nombre}, {marcaVehiculo}, {ccVehiculo}, {piloto}, {navegante}");
        }

        private void btnasd_Click(object sender, EventArgs e)
        {
            if (OnAgregarNavegante != null)
            {
                AgregarNaveganteEventArgs navigantArgs = new AgregarNaveganteEventArgs();
                navigantArgs.nombre = this.NameTextBox.Text;
                OnAgregarNavegante(this, navigantArgs);
            }
        }

        private void AgregarEquipoButton_Click(object sender, EventArgs e)
        {
            if (OnAgregarEquipo != null)
            {
                AgregarEquipoEventArgs teamArgs = new AgregarEquipoEventArgs();
                teamArgs.nombre = this.tbName.Text;
                Vehiculo auto = new Vehiculo(this.tbBrand.Text, Convert.ToInt32(this.tbCC.Text));
                teamArgs.vehiculo = auto;
                Persona piloto1 = new Persona(this.PilotoCB.SelectedItem.ToString(), Rol.Piloto);
                teamArgs.piloto = piloto1;
                Persona navegante1 = new Persona(this.NaveganteCB.SelectedItem.ToString(), Rol.Navegante);
                teamArgs.navegante = navegante1;
                OnAgregarEquipo(this, teamArgs);
            }
        }
    }
}
