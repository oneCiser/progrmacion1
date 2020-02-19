using System;
using System.Collections.Generic;
using System.Text;

namespace SantaClaus
{
    class RUN
    {
        static void Main(string[] args) {
            var lista = (new LectorCSV()).importEstudiantesCSV();
            foreach (var item in lista) {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }
    }
}
