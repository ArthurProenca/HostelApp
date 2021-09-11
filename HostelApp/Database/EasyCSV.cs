using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace HostelApp.Database
{
    public class EasyCSV
    {
        public static void CriaCSV()
        {
            try
            {
                StreamWriter sw = new StreamWriter("../../../Database/csv.csv");
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

        public static void InsereCSV(string Content)
        {
            List<string> aux = new List<string>();
            aux = LeCSV();
            try
            {
                StreamWriter sw = new StreamWriter("../../../Database/csv.csv");

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
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        public static List<string> LeCSV()
        {
            string line;
            List<string> list = new List<string>();
            int i = 0;

            try
            {
                StreamReader sr = new StreamReader("../../../Database/csv.csv");
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
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

            return list;
        }

        public static void MostraCSV()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader("../../../Database/csv.csv");
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
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}