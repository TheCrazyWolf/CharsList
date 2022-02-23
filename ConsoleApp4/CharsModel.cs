using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class CharsModel
    {
        public char Char { get; set; }

        public CharsModel (char a) //При создании экземпляра мы принимаем букву
        {
            Char = a; //задаем свойству полученную букву
        } 

    }
}
