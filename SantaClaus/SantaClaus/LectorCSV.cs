using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace SantaClaus
{
    class LectorCSV
    {
        public List<Curso> importCursosCSV() {
            using (var reader = new StreamReader(@"C:\Users\josea\Documents\JUAN\progrmacion1\data\cursos.txt"))
            {
                List<Curso> output = new List<Curso>();
                while (!reader.EndOfStream) {
                    var elements = reader.ReadLine().Split(",");
                    output.Add(new Curso(
                        elements[0],
                        elements[1],
                        float.Parse(elements[2])
                        ));

                
                }
                return output;
            }

        }
        public List<Estudiante> importEstudiantesCSV() {
            using (var reader = new StreamReader(@"C:\Users\josea\Documents\JUAN\progrmacion1\data\Estudiantes.txt"))
            {
                List<Estudiante> output = new List<Estudiante>();
                while (!reader.EndOfStream)
                {
                    var elements = reader.ReadLine().Split(",");
                    if (elements.Length == 4)
                    {
                        output.Add(new Particular(
                            Int32.Parse(elements[0]),
                            elements[1],
                            elements[2],
                            Int32.Parse(elements[3])
                            ));
                    }
                    else {
                        output.Add(new Afiliado(
                            Int32.Parse(elements[0]),
                            elements[1],
                            elements[2],
                            Int32.Parse(elements[3]),
                            Int32.Parse(elements[4])
                            ));
                    }


                }
                return output;
            }
        }
        public List<Curso> importCursosHCSV()
        {
            using (var reader = new StreamReader(@"C:\Users\josea\Documents\JUAN\progrmacion1\data\cursosH2.txt"))
            {
                List<Curso> output = new List<Curso>();
                var head = reader.ReadLine().Split(",");
                int[] index = new int[head.Length];
                for (int i = 0; i < head.Length; i++) {
                    if (head[i].Equals("Nombre"))
                    {
                        index[0] = i;
                    }
                    else if (head[i].Equals("Horario"))
                    {
                        index[1] = i;
                    }
                    else {
                        index[2] = i;
                    }
                }
                
                while (!reader.EndOfStream)
                {
                    var elements = reader.ReadLine().Split(",");
                    output.Add(new Curso(
                        elements[index[0]],
                        elements[index[1]],
                        float.Parse(elements[index[2]])
                        ));


                }
                return output;
            }

        }

    }
}
