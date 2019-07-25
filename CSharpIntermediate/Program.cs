using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/* Don't change anything here.
 * Do not add any other imports. You need to write
 * this program using only these libraries 
 */

namespace ProgramNamespace
{
    /* You may add helper classes here if necessary */

    public class Program
    {
        public static List<String> processData(
                                        IEnumerable<string> lines)
        {
            /* 
             * Do not make any changes outside this method.
             *
             * Modify this method to process `array` as indicated
             * in the question. At the end, return the size of the
             * array. 
             *
             * Do not print anything in this method
             *
             * Submit this entire program (not just this function)
             * as your answer
             */
            Dictionary<string, Int16> librariesLatestVersion = new Dictionary<string, Int16>();
            List<String> products = new List<String>();
            foreach (var library in lines)
            {
                string versionName = library.Split(',')[2].Trim();
                short version = Convert.ToInt16(versionName.Substring(1, versionName.Length - 1));
                string libraryName = library.Split(',')[1].Trim();

                if (librariesLatestVersion != null &&
                    librariesLatestVersion.ContainsKey(libraryName) &&
                    librariesLatestVersion[libraryName] < version)
                {
                    librariesLatestVersion[libraryName] = version;
                }
                else if (librariesLatestVersion.Count == 0 ||
                    !librariesLatestVersion.ContainsKey(libraryName))
                {
                    librariesLatestVersion.Add(libraryName, version);
                }
            }

            foreach (var library in lines)
            {
                string versionName = library.Split(',')[2].Trim();
                short version = Convert.ToInt16(library.Split(',')[2].Trim().Substring(1, versionName.Length - 1));
                string libraryName = library.Split(',')[1].Trim();

                if ((librariesLatestVersion[libraryName] == version && !products.Any()) || (librariesLatestVersion[libraryName] == version && products.Any() && products.Any(item => item != library.Split(',')[0].Trim())))
                    products.Add(library.Split(',')[0].Trim());
            }

            return products;
        }

        static void Main(string[] args)
        {
            //try
            //{
            //    List<String> retVal = processData(
            //                          File.ReadAllLines("input.txt"));
            //    File.WriteAllLines("output.txt", retVal);
            //}
            //catch (IOException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            f2();
        }

        static void f1(ref String s1, String s2)
        {
            s1 = s1 + "0";
            s2 = s2 + "0";
        }
        static String f3()
        {
            String s1 = "42", s2 = "43";
            f1(ref s1, s2);
            return s1 + s2;
        }

        static void f4()
        {
            try
            {
                int[] array = new int[3];
                array[3] = 3;
                Console.Write("A");
            }
            catch (IndexOutOfRangeException)
            {
                Console.Write("B");
            }
            Console.Write("C");
        }

        static void f5(S s)
        {
            s.i += 1;
        }
        static String f6()
        {
            S s;
            s.i = 42;
            f5(s);
            return s.i.ToString();
        }

        static String f7(bool x)
        {
            int i = 2;
            if (x)
            {
                //int i = 3;
            }
            else
            {
                //int i = 4;
            }
            return i.ToString();
        }

        static int f2()
        {
            String s = "Hello\0world";
            return s.Length;
        }
    }

    struct S
    {
        public int i;
    }

    class S1
    {
        public int I;
    }


}
