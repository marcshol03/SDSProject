//Hernandez Rodriguez Manuel Isaías
//Ramirez Gonzalez Marco Polo
//Tiscareño Hernandez Axel Josue

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SDSProject.Models
{
    internal class Inventario
    {
        // Atributos privados
        private string lugar;
        private string fechaExtaccion;
        private string fechaVencimiento;
        private string cantidad;
        private string volumen;
        private string status;
        private byte[] image;

        // Propiedades públicas
        public string Lugar
        {
            get { return lugar; }
            set { lugar = value; }
        }

        public string FechaExtaccion
        {
            get { return fechaExtaccion; }
            set { fechaExtaccion = value; }
        }

        public string FechaVencimiento
        {
            get { return fechaVencimiento; }
            set { fechaVencimiento = value; }
        }

        public string Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public string Volumen
        {
            get { return volumen; }
            set { volumen = value; }
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
        public Inventario()
        {
        }

        // Constructor parametrizado
        public Inventario(string lugar, string fechaExtaccion, string fechaVencimiento, string cantidad, string volumen, string status, byte[] image)
        {
            this.lugar = lugar;
            this.fechaExtaccion = fechaExtaccion;
            this.fechaVencimiento = fechaVencimiento;
            this.cantidad = cantidad;
            this.volumen = volumen;
            this.status = status;
            this.image = image;
        }

        // Métodos de negocio y sobrecarga
        public string ObtenerResumen()
        {
            return $"Lugar: {lugar} - Cantidad: {cantidad} [{status}]";
        }

        public string ObtenerResumen(bool incluirFechas)
        {
            if (incluirFechas)
            {
                return $"Lugar: {lugar} | Extracción: {fechaExtaccion} | Vencimiento: {fechaVencimiento} | Cantidad: {cantidad} | Volumen: {volumen} [{status}]";
            }
            return ObtenerResumen();
        }
    }
}