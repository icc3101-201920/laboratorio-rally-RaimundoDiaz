using ModelosRally;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistasRally
{
    class Controller
    {
        List<Persona> Pilotos;
        List<Persona> Navegantes;
        List<Equipo> Equipos;
        Form1 vistaPilotos;

        public Controller(Form1 vistaPilotos)
        {
            Pilotos = new List<Persona>();
            this.vistaPilotos = vistaPilotos;
            this.vistaPilotos.OnAgregarPiloto += VistaPilotos_OnAgregarPiloto;
            Navegantes = new List<Persona>();
            this.vistaPilotos.OnAgregarNavegante += VistaPilotos_OnAgregarNavegante;
            Equipos = new List<Equipo>();
            this.vistaPilotos.OnAgregarEquipo += VistaPilotos_OnAgregarEquipo;
        }

        private void VistaPilotos_OnAgregarPiloto(object sender, AgregarPilotoEventArgs e)
        {
            Persona piloto = new Persona(e.nombre, Rol.Piloto);
            Pilotos.Add(piloto);
            vistaPilotos.ActualizarListadoPilotos(piloto);
        }

        private void VistaPilotos_OnAgregarNavegante(object sender, AgregarNaveganteEventArgs e)
        {
            Persona navegante = new Persona(e.nombre, Rol.Navegante);
            Navegantes.Add(navegante);
            vistaPilotos.ActualizarListadoNavegantes(navegante);
        }
        private void VistaPilotos_OnAgregarEquipo(object sender, AgregarEquipoEventArgs e)
        {
            Equipo equipo = new Equipo(e.nombre, e.vehiculo, e.piloto, e.navegante);
            string nombre = e.nombre;
            string marca = e.vehiculo.getMarca();
            string cilindrada = Convert.ToString(e.vehiculo.getCilindrada());
            string piloto = e.piloto.GetNombre();
            string navegante = e.navegante.GetNombre();
            Equipos.Add(equipo);
            vistaPilotos.ActualizarListadoEquipos(nombre, marca,  cilindrada, piloto, navegante);
        }

    }
}
