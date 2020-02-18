using System;
using System.Collections.Generic;
using System.Text;

namespace SantaClaus
{
    class Curso
    {
/*                public string nombre;
                public string horario;
                public float costo;

                //constructor sin argumentos
                public Curso()
                {
                }

                //constructor con argumentos, observe que no lleva tipo de retorno
                public Curso(string nom, string hor, float cos)
                {
                    this.nombre = nom;
                    this.horario = hor;
                    this.costo = cos;
                }

                //constructor con argumentos, observe que este sólo tiene 2 argumentos
                public Curso(string nom, string hor)
                {
                    this.nombre = nom;
                    this.horario = hor;
                }

                //método ToString sirve para armar una cadena definida a nuestro gusto 
                //con los valores del objeto. Esto se hace dentro de la clase  
                public override string ToString()
                {
                    return string.Format("{0}\t{1}\t\t{2:C2}",
                       nombre, horario, costo);
                }

*/        


        // ahora considere los ajustes que se realizan cuando los atributos son de visibilidad privada

        private string nombre;
        private string horario;
        private float costo;

        //constructor sin argumentos
        public Curso()
        {
        }

        //constructor con argumentos, observe que no lleva tipo de retorno
        public Curso(string nom, string hor, float cos)  //constructor con 3 argumentos
        {
            this.nombre = nom;
            this.horario = hor;
            this.costo = cos;
        }

        //constructor con argumentos, observe que este sólo tiene 2 argumentos
        public Curso(string nom, string hor) //constructor con dos argumentos
        {
            this.nombre = nom;
            this.horario = hor;
        }

        //getters y setters para el atributo nombre 
        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string nuevoNombre)
        {
            this.nombre = nuevoNombre;
        }

        //getters y setters para el atributo horario 
        public string getHorario()
        {
            return horario;
        }
        public void setHorario(string nuevoHorario)
        {
            horario = nuevoHorario;
        }

        //getters y setters para el atributo costo 
        public float getCosto()
        {
            return costo;
        }
        public void setCosto(float nuevoCosto)
        {
            costo = nuevoCosto;
        }

        //método ToString sirve para armar una cadena definida a nuestro gusto 
        //con los valores del objeto. Esto se hace dentro de la clase  
        public override string ToString()
        {
            return string.Format("{0,-20} {1,-30} {2:C2}",
            getNombre(), getHorario(), getCosto());
            //"{0}\t\t{1}\t\t{2:C2}",
        }

        public void capturarDatosPorConsola()
        {
            Console.WriteLine("\nIntroduzca los datos de un nuevo curso");
            Console.Write("nombre: "); setNombre(Console.ReadLine());
            Console.Write("horario: "); setHorario(Console.ReadLine());
            Console.Write("valor: "); setCosto(Convert.ToSingle(Console.ReadLine()));
            //Console.Write("valor otra vez: "); setCosto(float.Parse(Console.ReadLine()));
        }

    }
}
