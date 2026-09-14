//Hernandez Rodriguez Manuel Isaías
//Ramirez Gonzalez Marco Polo
//Tiscareño Hernandez Axel Josue

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDSProject.Models
{
    internal class ComprobanteDonacion
    {
        // Atributos privados
        private string fecha;
        private string hora;
        private string lugar;
        private string idUsuario;
        private string idDonacion;
        private string personalMedico;
        private string centroDonacion;
        private string componenteSanguineo;
        private string status;
        private byte[] image;

        // Propiedades públicas
        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        public string Lugar
        {
            get { return lugar; }
            set { lugar = value; }
        }

        public string IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public string IdDonacion
        {
            get { return idDonacion; }
            set { idDonacion = value; }
        }

        public string PersonalMedico
        {
            get { return personalMedico; }
            set { personalMedico = value; }
        }

        public string CentroDonacion
        {
            get { return centroDonacion; }
            set { centroDonacion = value; }
        }

        public string ComponenteSanguineo
        {
            get { return componenteSanguineo; }
            set { componenteSanguineo = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public byte[] Image
        {
            get { return image; }
            set { image = value; }
        }

        // Constructor por defecto (vacío)
        public ComprobanteDonacion()
        {
        }

        // Constructor parametrizado (también integrando componentSanguineo que faltaba asignar en tu versión original)
        public ComprobanteDonacion(string fecha, string hora, string lugar, string idUsuario, string idDonacion, string personalMedico, string centroDonacion, string componenteSanguineo, string status, byte[] image)
        {
            this.fecha = fecha;
            this.hora = hora;
            this.lugar = lugar;
            this.idUsuario = idUsuario;
            this.idDonacion = idDonacion;
            this.personalMedico = personalMedico;
            this.centroDonacion = centroDonacion;
            this.componenteSanguineo = componenteSanguineo;
            this.status = status;
            this.image = image;
        }

        // Métodos de negocio y sobrecarga
        public string ObtenerComprobante()
        {
            return $"Comprobante de Donación {idDonacion} - Fecha: {fecha} [{status}]";
        }

        public string ObtenerComprobante(bool detallado)
        {
            if (detallado)
            {
                return $"Comprobante {idDonacion} | Usuario: {idUsuario} | Fecha/Hora: {fecha} {hora} | Lugar: {lugar} | Centro: {centroDonacion} | Médico: {personalMedico} | Comp: {componenteSanguineo} [{status}]";
            }
            return ObtenerComprobante();
        }
    }
}