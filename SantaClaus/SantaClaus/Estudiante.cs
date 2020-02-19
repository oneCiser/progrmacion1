using System;
using System.Collections.Generic;
using System.Text;

namespace SantaClaus
{
    class Estudiante
    {
        protected int CC;
        protected string apellido;
        protected string nombre;
        protected int celular;
        public void setCC(int CC) { this.CC = CC; }
        public void setApellido(string Apellido) { this.apellido = Apellido; }
        public void setNombre(string Nombre) { this.nombre = Nombre; }
        public void setCelular(int Celular) { this.celular = Celular; }
        public int getCC() { return this.CC; }
        public string getApellido() { return this.apellido; }
        public string getNombre() { return this.nombre; }
        public int getCelular() { return this.celular; }
    }
}
