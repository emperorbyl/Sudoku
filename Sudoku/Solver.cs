using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sudoku
{
    public class Solver
    {
        private string inputFile { get; set; }
        private string outputFile { get; set; }
        private Board board;
        Solver(string input, string output)
        {
            inputFile = input;
            outputFile = output;
        }

        public void IntializeBoard()
        {
            if (string.IsNullOrEmpty(inputFile))
                return;
            string[] file = File.ReadAllLines(inputFile);
            int count = 0;
            string characters = file[1];
            
            int.TryParse(file[0], out count);
            board = new Board(count);
            for (int i = 2; i < file.Length; i++)
                board.grid.Add(new Square(Char.Parse(file[i])));
            foreach (var cha in characters)
                board.validSymbol.Add(cha);
        } 
    }
}
