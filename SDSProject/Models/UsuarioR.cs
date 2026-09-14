//Hernandez Rodriguez Manuel Isaías
//Ramirez Gonzalez Marco Polo
//Tiscareño Hernandez Axel Josue

using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDSProject.Models
{
    internal class UsuarioR
    {
        // Atributos privados
        private string nombre;
        private string apellido;
        private string fechaNacimiento;
        private string id;
        private string estadoR;
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
        public UsuarioR()
        {
        }

        // Constructor parametrizado
        public UsuarioR(string nombre, string apellido, string fechaNacimiento, string id, string estadoR, string status, byte[] image)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.id = id;
            this.estadoR = estadoR;
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
