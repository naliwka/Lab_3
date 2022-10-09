using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_2
{
    internal class Content 
    {
        private string content = "";
        public Content(string content) 
        {
            this.content = content;
        }
        public string ContentValue
        {
            get
            {
                return content;
            }
        }
        public void Show(Content content)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Content of the book: {content.ContentValue}");
        }
    }
}
