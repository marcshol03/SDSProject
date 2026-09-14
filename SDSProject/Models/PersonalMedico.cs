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
    internal class PersonalMedico
    {
        // Atributos privados
        private string nombreCompleto;
        private int cedula;
        private string status;
        private byte[] image;

        // Propiedades públicas
        public string NombreCompleto
        {
            get { return nombreCompleto; }
            set { nombreCompleto = value; }
        }

        public int Cedula
        {
            get { return cedula; }
            set { cedula = value; }
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
        public PersonalMedico()
        {
        }

        // Constructor parametrizado
        public PersonalMedico(string nombreCompleto, int cedula, string status, byte[] image)
        {
            this.nombreCompleto = nombreCompleto;
            this.cedula = cedula;
            this.status = status;
            this.image = image;
        }

        // Métodos de negocio y sobrecarga
        public string ObtenerResumen()
        {
            return $"Personal Médico: {nombreCompleto} - Cédula: {cedula} [{status}]";
        }

        public string ObtenerResumen(string cargo)
        {
            return $"{cargo}: {nombreCompleto} - Cédula: {cedula} [{status}]";
        }
    }
}