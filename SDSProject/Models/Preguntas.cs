//Hernandez Rodriguez Manuel Isaías
//Ramirez Gonzalez Marco Polo
//Tiscareño Hernandez Axel Josue

using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDSProject.Models
{
    internal class Preguntas
    {
        // Atributos privados
        private int edad;
        private double peso;
        private double estatura;
        private string pruebaBucal;
        private string tipoSangre;
        private string tatuajes;
        private string parejaSex;
        private string perforaciones;
        private string enfermedades;
        private string alergias;
        private string medicamentosRecientes;
        private string enfermedadesCardiacas;
        private string status;
        private byte[] image;

        // Propiedades públicas
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public double Estatura
        {
            get { return estatura; }
            set { estatura = value; }
        }

        public string PruebaBucal
        {
            get { return pruebaBucal; }
            set { pruebaBucal = value; }
        }

        public string TipoSangre
        {
            get { return tipoSangre; }
            set { tipoSangre = value; }
        }

        public string Tatuajes
        {
            get { return tatuajes; }
            set { tatuajes = value; }
        }

        public string ParejaSex
        {
            get { return parejaSex; }
            set { parejaSex = value; }
        }

        public string Perforaciones
        {
            get { return perforaciones; }
            set { perforaciones = value; }
        }

        public string Enfermedades
        {
            get { return enfermedades; }
            set { enfermedades = value; }
        }

        public string Alergias
        {
            get { return alergias; }
            set { alergias = value; }
        }

        public string MedicamentosRecientes
        {
            get { return medicamentosRecientes; }
            set { medicamentosRecientes = value; }
        }

        public string EnfermedadesCardiacas
        {
            get { return enfermedadesCardiacas; }
            set { enfermedadesCardiacas = value; }
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
        public Preguntas()
        {
        }

        // Constructor parametrizado
        public Preguntas(int edad, double peso, double estatura, string pruebaBucal, string tipoSangre, string tatuajes, string parejaSex, string perforaciones, string enfermedades, string alergias, string medicamentosRecientes, string enfermedadesCardiacas, string status, byte[] image)
        {
            this.edad = edad;
            this.peso = peso;
            this.estatura = estatura;
            this.pruebaBucal = pruebaBucal;
            this.tipoSangre = tipoSangre;
            this.tatuajes = tatuajes;
            this.parejaSex = parejaSex;
            this.perforaciones = perforaciones;
            this.enfermedades = enfermedades;
            this.alergias = alergias;
            this.medicamentosRecientes = medicamentosRecientes;
            this.enfermedadesCardiacas = enfermedadesCardiacas;
            this.status = status;
            this.image = image;
        }

        // Métodos de negocio y sobrecarga
        public string ObtenerResumen()
        {
            return $"Edad: {edad} - Tipo de Sangre: {tipoSangre} [{status}]";
        }

        public string ObtenerResumen(bool detallado)
        {
            if (detallado)
            {
                return $"Edad: {edad} | Peso: {peso}kg | Estatura: {estatura}m | Sangre: {tipoSangre} | Enf: {enfermedades} | Alergias: {alergias} [{status}]";
            }
            return ObtenerResumen();
        }
    }
}
