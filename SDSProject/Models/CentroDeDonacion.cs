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
    internal class CentroDonacion
    {
        // Atributos privados
        private string clinica;
        private string direccion;
        private string telefono;
        private string correoElectronico;
        private string estadoR;
        private string status;
        private byte[] image;

        // Propiedades públicas
        public string Clinica
        {
            get { return clinica; }
            set { clinica = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string CorreoElectronico
        {
            get { return correoElectronico; }
            set { correoElectronico = value; }
        }

        public string EstadoR
        {
            get { return estadoR; }
            set { estadoR = value; }
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
        public CentroDonacion()
        {
        }

        // Constructor parametrizado
        public CentroDonacion(string clinica, string direccion, string telefono, string correoElectronico, string estadoR, string status, byte[] image)
        {
            this.clinica = clinica;
            this.direccion = direccion;
            this.telefono = telefono;
            this.correoElectronico = correoElectronico;
            this.estadoR = estadoR;
            this.status = status;
            this.image = image;
        }

        // Métodos de negocio y sobrecarga
        public string ObtenerInformacion()
        {
            return $"Clínica: {clinica} - Teléfono: {telefono} [{status}]";
        }

        public string ObtenerInformacion(bool incluirCorreo)
        {
            if (incluirCorreo)
            {
                return $"Clínica: {clinica} - Teléfono: {telefono} - Correo: {correoElectronico} [{status}]";
            }
            return ObtenerInformacion();
        }
    }
}