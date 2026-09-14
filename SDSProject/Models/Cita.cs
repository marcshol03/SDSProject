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
    internal class Cita
    {
        // Atributos privados
        private string fecha;
        private string hora;
        private string lugar;
        private string idUsuario;
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
        public Cita()
        {
        }

        // Constructor parametrizado
        public Cita(string fecha, string hora, string lugar, string idUsuario, string status, byte[] image)
        {
            this.fecha = fecha;
            this.hora = hora;
            this.lugar = lugar;
            this.idUsuario = idUsuario;
            this.status = status;
            this.image = image;
        }

        // Métodos de negocio y sobrecarga
        public string ObtenerDetalle()
        {
            return $"Cita el {fecha} a las {hora} - Estado: {status}";
        }

        public string ObtenerDetalle(bool mostrarLugar)
        {
            if (mostrarLugar)
            {
                return $"Cita el {fecha} a las {hora} en {lugar} - Estado: {status}";
            }
            return ObtenerDetalle();
        }
    }
}