using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of the book:");
            Title title = new Title(Console.ReadLine());
            Console.WriteLine("Enter the author of the book:");
            Author author = new Author(Console.ReadLine()); 
            Console.WriteLine("Enter the content of the book:");
            Content content = new Content(Console.ReadLine());

            Books book = new Books(title, author, content); 
            book.ShowBook(book, title, author, content);
        }
    }
}
