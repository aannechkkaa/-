using System;
using System.Text;
using System.IO;

namespace CamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fin = new StreamReader("input.txt");
            StreamWriter fout = new StreamWriter("output.txt");
            fin.Close();
            fout.Close();
        }
    }
}
