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
    internal class RechazoMedico
    {
        // Atributos privados
        private string motivo;
        private string fecha;
        private string hora;
        private string idUsuario;
        private string status;
        private byte[] image;

        // Propiedades públicas
        public string Motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }

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
        public RechazoMedico()
        {
        }

        // Constructor parametrizado
        public RechazoMedico(string motivo, string fecha, string hora, string idUsuario, string status, byte[] image)
        {
            this.motivo = motivo;
            this.fecha = fecha;
            this.hora = hora;
            this.idUsuario = idUsuario;
            this.status = status;
            this.image = image;
        }

        // Métodos de negocio y sobrecarga
        public string ObtenerResumen()
        {
            return $"Rechazo - Motivo: {motivo} [{status}]";
        }

        public string ObtenerResumen(bool detallado)
        {
            if (detallado)
            {
                return $"Rechazo ID Usuario: {idUsuario} | Motivo: {motivo} | Fecha: {fecha} {hora} [{status}]";
            }
            return ObtenerResumen();
        }
    }
}