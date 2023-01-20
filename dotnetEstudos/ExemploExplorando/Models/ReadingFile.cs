using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class ReadingFile
    {
        public (bool Sucess, string[] Lines, int NumberLines) ReadFile(string path)
        {
            try
            {
            string[] lines = File.ReadAllLines(path);

            return (true, lines, lines.Count());
            }catch(Exception)
            {
                return (false, new string[0], 0);
            }


        }
    }
}