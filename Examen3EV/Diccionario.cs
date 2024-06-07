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
    internal class Diccionario
    {
        public List<String> words;
        public int wordCount;

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

            // primer paso, analizar la primera cadena
            if (f1 == null || f1.Length == 0)
            {
                return -1;
            }

            int posIni = 0;
            int posFin = f1.IndexOf(' '); // encontramos el primer espacio

            while (posFin != -1)
            {
                word = f1.Substring(posIni, posFin - posIni);

                if (word.Length > 0 && !words.Contains(word))
                {
                    words.Add(word);
                    wordCount++;
                }

                posIni = posFin + 1;
                posFin = f1.IndexOf(' ', posIni);
            }

            // añadimos la última palabra
            word = f1.Substring(posIni, f1.Length - posIni);
            words.Add(word);
            wordCount++;

            // segundo paso, analizar la segunda cadena
            if (f2 == null || f2.Length == 0) return -2;

            while (posFin != -1)
            {
                word = f2.Substring(posIni, posFin - posIni);

                if (word.Length > 0 && !words.Contains(word))
                {
                    words.Add(word);
                    wordCount++;
                }

                posIni = posFin + 1;
                posFin = f2.IndexOf(' ', posIni);
            }
            // añadimos la última palabra
            word = f2.Substring(posIni, f2.Length - posIni);
            words.Add(word);
            wordCount++;

            // tercer paso, Ordenar las palabras
            words.Sort();
            return 0;
        }
    }
}
