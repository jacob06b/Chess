using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ChessPieces
{
    public class Chess
    {
        //field
        
        
        
        //properties

        public int Value { get; private set; }
        public string Team { get; private set; }
        public int Number { get; private set; }
        public string Pos { get; private set; }
        public string Type { get; private set; }


    //Constructors
    public Chess(string type,string pos)
        {
            Pos = pos;
            Type = type;    
    
        }

    public void Move(string square)
        {
            string temp = square.Substring(0, 1);
            int letterCheck = (int)Convert.ToChar(temp);
            string temp1 = square.Substring(1);
            int numCheck = Convert.ToInt32(temp1);

            if (letterCheck > 104 || letterCheck < 97 || numCheck > 8 || numCheck < 1)
            {
                Console.WriteLine("invalid square");
            }
            else
            {
                Pos = square;
                Console.WriteLine(Type, "moved to", square);
            }
                
        }

    }
}
