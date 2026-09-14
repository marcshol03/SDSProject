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
    internal class ComponenteSanguineo
    {
        // Atributos privados
        private string tipoSangre;
        private string plaquetas;
        private string plasma;
        private string globulosRojos;
        private string globulosBlancos;
        private string status;
        private byte[] image;

        // Propiedades públicas
        public string TipoSangre
        {
            get { return tipoSangre; }
            set { tipoSangre = value; }
        }

        public string Plaquetas
        {
            get { return plaquetas; }
            set { plaquetas = value; }
        }

        public string Plasma
        {
            get { return plasma; }
            set { plasma = value; }
        }

        public string GlobulosRojos
        {
            get { return globulosRojos; }
            set { globulosRojos = value; }
        }

        public string GlobulosBlancos
        {
            get { return globulosBlancos; }
            set { globulosBlancos = value; }
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
        public ComponenteSanguineo()
        {
        }

        // Constructor parametrizado
        public ComponenteSanguineo(string tipoSangre, string plaquetas, string plasma, string globulosRojos, string globulosBlancos, string status, byte[] image)
        {
            this.tipoSangre = tipoSangre;
            this.plaquetas = plaquetas;
            this.plasma = plasma;
            this.globulosRojos = globulosRojos;
            this.globulosBlancos = globulosBlancos;
            this.status = status;
            this.image = image;
        }

        // Métodos de negocio y sobrecarga
        public string ObtenerResumen()
        {
            return $"Tipo de Sangre: {tipoSangre} - Estado: {status}";
        }

        public string ObtenerResumen(bool detalleCompleto)
        {
            if (detalleCompleto)
            {
                return $"Tipo: {tipoSangre} | Plaquetas: {plaquetas} | Plasma: {plasma} | G. Rojos: {globulosRojos} | G. Blancos: {globulosBlancos} [{status}]";
            }
            return ObtenerResumen();
        }
    }
}