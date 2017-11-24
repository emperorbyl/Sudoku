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
        private Guess guess = new Guess();
        private OneChoice one = new OneChoice();
        public Solver(string input, string output)
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
            if (count != 4 && count != 9 && count != 16 && count != 25 && count != 36)
                return;
            board = new Board(count);
            for (int i = 2; i < file.Length; i++)
                for(int j = 0; j< file[i].ToString().Length;j++)
                    if(file[i][j] != ' ')
                        board.grid.Add(new Square(file[i][j]));
            foreach (var sq in board.grid)
            {
                foreach (var cha in characters)
                    if (cha != ' ' && !sq.validSymbol.Contains(cha))
                        sq.validSymbol.Add(cha);
                for (int i = 0; i < count; i++)
                    sq.row.content.Add(board.grid[i].symbol);
                for (int i = 1; i < count * count; i *= count)
                    sq.column.content.Add(board.grid[i].symbol);
                for (int i = 0; i < Math.Sqrt(count); i++)
                    for (int j = 0; j < Math.Sqrt(count); j++)
                        sq.block.content.Add(board.grid[i * j].symbol);
            }
        } 
        public void Solve()
        {
            foreach (var sq in board.grid)
            {
                if (sq.row.content.Count == board.size-1 || sq.block.content.Count == board.size-1 || sq.column.content.Count == board.size-1)
                    one.FindCharacter(sq);
                else
                    guess.FindCharacter(sq);
            }
            if(!string.IsNullOrEmpty(outputFile))
            {
                var file = new StreamWriter(outputFile);
                for (int i = 0; i < board.size; i++)
                {
                    for (int j = 0; j < board.size; j++)
                        file.Write(board.grid[i * j].symbol + " ");
                    file.Write("\n");
                }
            }
            else
            {
                for (int i = 0; i < board.size; i++)
                {
                    for (int j = 0; j < board.size; j++)
                        Console.Write(board.grid[i * j].symbol + " ");
                    Console.Write("\n");
                }
            }
        }
    }
}
