using System;
using System.IO;
using System.Collections.Generic;

namespace DictonaryExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            Dictionary<string, int> candidatos = new Dictionary<string, int>();
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string nome = line[0];
                        int votos = int.Parse(line[1]);
                        if (candidatos.ContainsKey(nome))
                        {
                            candidatos[nome] += votos;
                        }
                        if (!candidatos.ContainsKey(nome))
                        {
                            candidatos.Add(nome, votos);
                        }
                        
                    }
                }
                Console.WriteLine();
                foreach (KeyValuePair<string, int> item in candidatos)
                {
                    if(item.Key == item.Key)
                    {

                    }
                    Console.WriteLine($"{item.Key}, {item.Value}");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
