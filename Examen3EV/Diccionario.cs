using Examen3EV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen3EV
{
    // Clase que construye un diccionario de palabras a partir de dos frases
    // El dicionario estará ordenado alfabéticamente
    public class Diccionario
    {
        public List<String> words;

        private int wordCount;

        public int WordCount
        {
            get { return wordCount; }
            set { wordCount = value; }
        }

        public Diccionario()
        {
            words = new List<String>();
            wordCount = 0;
        }

        // Método que analiza las frases
        // Primero comprueba que no son nulas o vacías
        // Después agrega las palabras al diccionario, omitiendo repeticiones
        // Códigos de error:
        // -1: la primera cadena no es válida
        // -2: la segunda cadena no es válida
        // 0: operación correcta

        public int analizar(string f1, string f2)
        {
            string word;
            words.Clear();
            wordCount = 0;

            string error = "null o vacio";

            // primer paso, analizar la primera cadena
            if (f1 == null || f1.Length == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(error), "La frase no puede ser null o vacío");
            }

            int posIni = 0;
            int posFin = f1.IndexOf(' '); // encontramos el primer espacio

            while (posFin != -1)
            {
                word = f1.Substring(posIni, posFin - posIni);

                if (word.Length > 0 && !words.Contains(word))
                {
                    AnyadirDiccionario(word);
                }

                posIni = posFin + 1;
                posFin = f1.IndexOf(' ', posIni);
            }

            // añadimos la última palabra
            word = f1.Substring(posIni, f1.Length - posIni);
            AnyadirDiccionario(word);

            // segundo paso, analizar la segunda cadena
            if (f2 == null || f2.Length == 0) return -2;

            while (posFin != -1)
            {
                word = f2.Substring(posIni, posFin - posIni);

                if (word.Length > 0 && !words.Contains(word))
                {
                    AnyadirDiccionario(word);
                }

                posIni = posFin + 1;
                posFin = f2.IndexOf(' ', posIni);
            }

            // añadimos la última palabra
            word = f2.Substring(posIni, f2.Length - posIni);

            // tercer paso, Ordenar las palabras
            words.Sort();
            return 0;
        }

        public void AnyadirDiccionario(string word)
        {
            words.Add(word);
            wordCount++;
        }
    }
}
