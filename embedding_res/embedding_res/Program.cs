using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace embedding_res
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = GetWordList();
            foreach (var items in list)
            {
                Console.WriteLine(items);
            }
        }

        private static List<string> GetWordList()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            using (var stream = assembly.GetManifestResourceStream("embedding_res.WordList.txt"))
            using (var reader = new StreamReader(stream))
            {
                string text = reader.ReadToEnd();
                string[] array = text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                List<string> list = array.ToList();
                return list;
            }
        }
        private static List<string> GetWord1List()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            using (var stream = assembly.GetManifestResourceStream("embedding_res.WordList.txt"))
            using (var reader = new StreamReader(stream))
                return reader
                        .ReadToEnd()
                        .Split(
                            new[] { Environment.NewLine },
                            StringSplitOptions.RemoveEmptyEntries)
                          .ToList();
        }

        
    }
    }

