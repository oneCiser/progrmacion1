using System;
using System.Collections.Generic;

namespace SantaClaus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos al Instituto SantaClaus");
            Console.WriteLine("\nCatálogo de cursos navideños");

            //se instancia un objeto con constructor sin argumentos
            //luego se van asignando valores
            /*Curso monos1 = new Curso();
            monos1.nombre = "Moños navideños nivel básico";
            monos1.horario = "lunes y miércoles de 8 a 10 am";
            monos1.costo = 75000F;
            //Console.WriteLine("\n{0}\n{1} Costo: {2:C2}", monos1.nombre, monos1.horario, monos1.costo);
            Console.WriteLine(monos1);
            */
            
            //se instancia un objeto con constructor con argumentos
            //desde el mismo comando de creación se pasan los valores del nuevo objeto
            //Curso monos2 = new Curso("Moño navideños nivel avanzado", "martes y viernes 7 a 9 pm", 150000F);
            //Console.WriteLine("\n{0}\n{1} Costo: {2:C2}", monos2.nombre, monos2.horario, monos2.costo);
            //Console.WriteLine(monos2);

            //pueden existir múltiples constructores, 
            //siempre y cuando tengan diferente número o tipo de argumentos
            /*Curso monos3 = new Curso("Moño navideños nivel super avanzado", "miércoles y sábado 10 a 12 m");
            monos3.costo = 50000f;
            //Console.WriteLine("\n{0}\n{1} Costo: {2:C2}", monos3.nombre, monos3.horario, monos3.costo);
            Console.WriteLine(monos3);
            */

            //********** instancias con atributos privados **************//

            Curso cocina1 = new Curso("Buñuelos", "miércoles y sábado 3 a 5 pm");
            cocina1.setCosto(50000f);
            //Console.WriteLine("{0}\t\t{1}\t\t{2:C2}", cocina1.getNombre(), cocina1.getHorario(), cocina1.getCosto());

            Curso cocina2 = new Curso("Natilla", "miércoles y sábado 1 a 3 pm",30000f);
            //Console.WriteLine(cocina2);

            Curso cocina3 = new Curso("Capón relleno", "martes y jueves 2 a 6 pm",120000f);
            //Console.WriteLine(cocina3);

            Curso cocina4 = new Curso();
            cocina4.capturarDatosPorConsola();
            //Console.WriteLine(cocina4);

            //crear un vector de objetos
            Curso[] vectorCursos = new Curso[4];
            vectorCursos[0] = cocina1;
            vectorCursos[1] = cocina2;
            vectorCursos[2] = cocina3;
            vectorCursos[3] = cocina4;
            
            Console.WriteLine("\nCatálogo de cursos de cocina navideños, usando vectores");
            Console.WriteLine("=======================================================");
            for (int i = 0; i < vectorCursos.Length; i++)
            {
                Console.WriteLine(vectorCursos[i]);
            }


            //crear un arrayList de objetos
            List<Curso> listaCursos = new List<Curso>();
            listaCursos.Add(cocina1);
            listaCursos.Add(cocina2);
            listaCursos.Add(cocina3);
            listaCursos.Add(cocina4);
            
            Console.WriteLine("\nCatálogo de cursos de cocina navideños, usando listas");
            Console.WriteLine("=====================================================");
            foreach (Curso esteCurso in listaCursos)
            {
                Console.WriteLine(esteCurso);
            }



            Console.ReadKey();
        }
    }
}
