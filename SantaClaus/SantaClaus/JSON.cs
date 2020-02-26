using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;


namespace SantaClaus
{
    class JSON
    {
        public void guardarCurso(Curso curso) {
            string documento = JsonConvert.SerializeObject(curso);
            Console.WriteLine(documento);
        }
        public Curso cargarCurso() {
            using (var reader = new StreamReader(@"C:\Users\josea\Documents\JUAN\progrmacion1\data\JSON.txt")) 
            {
                string json = reader.ReadToEnd();
                var curso = JsonConvert.DeserializeObject<Curso>(json);
                return curso;
            }
        }
        public void guardarCurso(List<Curso> cursos) {
            using (var reader = new StreamWriter(@"C:\Users\josea\Documents\JUAN\progrmacion1\data\JSON.txt"))
            {
                string json = JsonConvert.SerializeObject(cursos);
                reader.Write(json);
            }
        }
        public List<Curso> cargarCurso(int lista=1) {
            using (var reader = new StreamReader(@"C:\Users\josea\Documents\JUAN\progrmacion1\data\JSON.txt"))
            {
                return JsonConvert.DeserializeObject<List<Curso>>(reader.ReadToEnd());
                
            }
        }
    }
}
