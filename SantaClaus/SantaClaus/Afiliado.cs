using System;
using System.Collections.Generic;
using System.Text;

namespace SantaClaus
{
    class Afiliado:Estudiante
    {
        private int afiliacion;
        public Afiliado(int cc, string apellido, string nombre, int cel,int afil)
        {
            this.CC = cc;
            this.apellido = apellido;
            this.nombre = nombre;
            this.celular = cel;
            this.afiliacion = afil;
        }
        public void setAfiliacion(int Afiliacion) { this.afiliacion = Afiliacion; }
        public int getAfiliacion() { return afiliacion; }
        public override string ToString()
        {
            return "Afiliado: " + nombre+" "+apellido;
        }
    }
}
