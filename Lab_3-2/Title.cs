using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_2
{
    internal class Title 
    {
        private string title = "";
        public Title(string title)
        {
            this.title = title;
        }
        public string TitleValue
        {
            get
            {
                return title;
            }
        }
        public void Show(Title title)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"The name of the book is {title.TitleValue}"); 
        }
    }
}
