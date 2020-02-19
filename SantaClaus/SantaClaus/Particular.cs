using System;
using System.Collections.Generic;
using System.Text;

namespace SantaClaus
{
    class Particular:Estudiante
    {
        public Particular(int cc, string apellido, string nombre, int cel) {
            this.CC = cc;
            this.apellido = apellido;
            this.nombre = nombre;
            this.celular = cel;
        }
        public override string ToString() {
            return "Particular: "+nombre;
        }
    }
}
