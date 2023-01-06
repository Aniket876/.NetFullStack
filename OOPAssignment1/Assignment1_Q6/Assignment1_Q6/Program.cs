using System;

namespace Assignment1_Q6
{
    public enum booktype
    {
        Magazine = 100,
        Novel,
        Miscellaneous,
        Reference
    }
    struct Book
    {
        public int bookid;
        public string title;
        public double price;
        public booktype type;
        public void getdetails()
        {
            Console.WriteLine("enter bookid");
            bookid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter title");
            title = Console.ReadLine();
            Console.WriteLine("enter price");
            price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter book type");
            type  = (booktype)Convert.ToInt32(Console.ReadLine());
        }
        public void printdetails()
        {
            Console.WriteLine($"bookid is {bookid}");
            Console.WriteLine($"title is {title}");
            Console.WriteLine($"price is {price}");
            Console.WriteLine($"Booktype is {type}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.getdetails();
            b.printdetails();
            
        }
    }
}
