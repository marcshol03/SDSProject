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
    internal class UsuarioD
    {
        // Atributos privados
        private string nombre;
        private string apellido;
        private string fechaNacimiento;
        private string id;
        private string estadoResidencia;
        private string status;
        private byte[] image;

        // Propiedades públicas
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string EstadoResidencia
        {
            get { return estadoResidencia; }
            set { estadoResidencia = value; }
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

        // 1. Constructor por defecto (vacío)
        public UsuarioD()
        {
        }

        // 2. Constructor parametrizado
        public UsuarioD(string nombre, string apellido, string fechaNacimiento, string id, string estadoResidencia, string status, byte[] image)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.id = id;
            this.estadoResidencia = estadoResidencia;
            this.status = status;
            this.image = image;
        }

        // Métodos de negocio y sobrecarga
        public string ObtenerResumen()
        {
            return $"{nombre} {apellido} - Estado: {status}";
        }

        public string ObtenerResumen(string prefijo)
        {
            return $"{prefijo}: {nombre} {apellido} - Estado: {status}";
        }
    }
}