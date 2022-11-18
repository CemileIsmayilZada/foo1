using System.Drawing;
Console.WriteLine("enter the number of book");
int size = int.Parse(Console.ReadLine());
Book[] book=new Book[size];


for (int i = 0; i < size; i++)
{
    Console.WriteLine("Enter no:");
    int no = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter name:");
    string name = Console.ReadLine();

    Console.WriteLine("Enter genre:");
    string genre = Console.ReadLine();

    Console.WriteLine("Enter price:");
    string price = Console.ReadLine();

    Console.WriteLine("Enter count:");
    int count = int.Parse(Console.ReadLine());

    Book newBook = new Book(no, name, price, count, genre);
    book[i] = newBook;  
    
}
 static void FilterForPrice(int minPrice, int maxPrice)
{
    for (int i = 0; i < length; i++)
    {

    }
}
Console.WriteLine("1. Kitablari qiymete gore filterle\r\n2. Kitablar icinde axtaris\r\n3. Butun kitablari goster\r\n0. Proqrami bagla\r\n");
Console.WriteLine("ENTER MENU:");
int menu= int.Parse(Console.ReadLine());

switch (menu)
{ case 0:
        int minPrice= int.Parse(Console.ReadLine());
        int maxPrice= int.Parse(Console.ReadLine());
        FilterForPrice(minPrice, maxPrice);
            break;

    default:
}
