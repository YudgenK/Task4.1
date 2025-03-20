
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Task
{
    class task3
    {
        public void Run()
        {
            
                Console.Write("Введіть назву книги: ");
                string title = Console.ReadLine();

                Console.Write("Введіть автора книги: ");
                string author = Console.ReadLine();

                Console.Write("Введіть зміст книги: ");
                string content = Console.ReadLine();

                Book book = new Book(title, author, content);
                book.Show();
            
        }

    }
    class Title
    {
        public string Text { get; set; }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Назва книги: " + Text);
            Console.ResetColor();
        }
    }

    class Author
    {
        public string Name { get; set; }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Автор: " + Name);
            Console.ResetColor();
        }
    }

    class Content
    {
        public string Description { get; set; }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Зміст: " + Description);
            Console.ResetColor();
        }
    }

    class Book
    {
        public Title Title { get; set; }
        public Author Author { get; set; }
        public Content Content { get; set; }

        public Book(string title, string author, string content)
        {
            Title = new Title { Text = title };
            Author = new Author { Name = author };
            Content = new Content { Description = content };
        }

        public void Show()
        {
            Title.Show();
            Author.Show();
            Content.Show();
        }
    }
}
