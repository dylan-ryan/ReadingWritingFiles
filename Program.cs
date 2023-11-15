using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; //<----- reading/ writing files
using System.Threading.Tasks;

namespace ReadingWritingFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reading and Writing Files");
            Console.WriteLine();
            Console.WriteLine();

            //read all text
            string path = @"map.txt";
            //string input;
            //input = File.ReadAllText(path);
            //Console.WriteLine(input);
            //Console.WriteLine();

            //read all lines
            string[] MapRows;
            MapRows = File.ReadAllLines(path);
            for (int y = 0; y < MapRows.Length; y++)
            {
                string MapRow = MapRows[y];
                for (int x = 0; x < MapRow.Length; x++)
                {
                    //Console.WriteLine("map(" + x + "," + y + ") = " + tile);  //DEBUG

                    char tile = MapRow[x];
                    Console.Write(tile);
                    //map[x,y] = tile
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
