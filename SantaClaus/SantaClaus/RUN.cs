using System;
using System.Collections.Generic;
using System.Text;

namespace SantaClaus
{
    class RUN
    {
        static void Main(string[] args) {
            JSON json = new JSON();
            List<Curso> cursos = json.cargarCurso(1);
            foreach (var i in cursos)
            {
                
                Console.WriteLine(i.ToString());

            }
            Console.ReadKey();
        }
    }
}
