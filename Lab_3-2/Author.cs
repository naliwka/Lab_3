using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_2
{
    internal class Author 
    {
        private string author = "";
        public Author(string author)
        {
            this.author = author;
        }
        public string AuthorValue
        {
            get
            {
                return author;
            }
        } 
        public void Show(Author author)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"The author is {author.AuthorValue}");
        }
    }
}
