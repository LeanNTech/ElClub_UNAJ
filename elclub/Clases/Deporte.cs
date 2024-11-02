/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 2/11/2024
 * Hora: 16:22
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace elclub.Clases
{
    public class Deporte
    {
        private string nombreDepo;
        private int cupo;
        private int dniEntrenador;
        private string nombreEntrenador;
        private int cantInscriptos;
        private int costoCuota;
        private DateTime dias;
        private DateTime horarios;

        public string NombreDepo
        {
            get { return nombreDepo; }
            set { nombreDepo = value; }
        }
        public int Cupo
        { 
            get { return cupo; }
            set { cupo = value; }
        }

        public int DniEntrenador
        { 
            get { return dniEntrenador; }
            set { dniEntrenador = value; }
        }

        public string NombreEntrenador
        {
            get { return nombreDepo; }
            set { nombreDepo = value; }
        }

        public int CantInscriptos
        {
            get { return cantInscriptos; }
            set { cantInscriptos = value; }
        }

        public DateTime Dias
        { 
            get { return dias; } 
            set { dias = value; } 
        }

        public DateTime Horarios
        {
            get { return horarios; }
            set { horarios = value; }
        }

        public Deporte(string nombreDepo, int cupo, int dniEntrenador, string nombreEntrenador, int cantInscriptos, int costoCuota, DateTime dias, DateTime horarios)
        {
            this.nombreDepo = nombreDepo;
            this.cupo = cupo;
            this.dniEntrenador = dniEntrenador;
            this.nombreEntrenador = nombreEntrenador;
            this.cantInscriptos = cantInscriptos;
            this.costoCuota = costoCuota;
            this.dias = dias;
            this.horarios = horarios;
        }
    }
}
