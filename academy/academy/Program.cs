using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academy
{
    public class Program
    {
        static void Main(string[] args)
        {
            Library book = new Library();
            book.Input();
            /*Book my}Book;
            myBook.title = "Clicker";
            myBook.author = "Alan Wake";
            myBook.Display();
            Book b2 = new Book("monster", "Mary Shelley");
            Console.ReadLine();
             * */
        }
    }
    struct Book
    {
        public string title;
    }
    public class Library
    {
        
        Book[] bookArr = new Book[4];
        public void Input()
        {
            
            //string[] booksArray = new string[5];
            for (int i = 0; i < 4; i++)
            {

                bookArr[i] = ToString(Console.ReadLine());
                
            }
        }
    }
   
}
