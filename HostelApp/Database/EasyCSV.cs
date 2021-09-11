using System;
using System.Collections.Generic;
using System.IO;

namespace HostelApp.Database
{
    public class EasyCSV
    {
        public static void CriaCSV(string nome)
        {
            try
            {
                StreamWriter sw = new StreamWriter("../../../Database/" + nome);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Finished.");
            }
        }

        public static void InsereCSV(string Content, string nome)
        {
            List<string> aux = new List<string>();
            aux = LeCSV(nome);
            try
            {
                StreamWriter sw = new StreamWriter("../../../Database/" + nome);

                for (int i = 0; i < aux.Count; i++)
                {
                    sw.WriteLine(aux[i]);
                }

                sw.WriteLine(Content);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public static List<string> LeCSV(string nome)
        {
            string line;
            List<string> list = new List<string>();
            int i = 0;

            try
            {
                StreamReader sr = new StreamReader("../../../Database/" + nome);
                line = sr.ReadLine();
                while (line != null)
                {
                    list.Insert(i, line);
                    i++;
                    line = sr.ReadLine();
                }

                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            return list;
        }

        public static void MostraCSV(string nome)
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader("../../../Database/" + nome);
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }

                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}