using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_2
{
    internal class Books 
    {
        private Title title;
        private Author author;
        private Content content;
        public Title Title { get { return title; } set { title = value; } }
        public Author Author { get { return author; } set { author = value; } }
        public Content Content { get { return content; } set { content = value; } }
   
        public Books(Title title, Author author, Content content)
        {
            this.title = title;
            this.author = author;
            this.content = content;
        }
        public void ShowBook(Books book, Title title, Author author, Content content)
        {            
            book.Title.Show(title);
            book.Author.Show(author);
            book.Content.Show(content);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
