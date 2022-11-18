
    internal class Book:Product
    {
    public string genre;

    public Book(int no,  string name, string price, int count, string genre) :base( no,  name,  price,  count)
    {
        this.genre = genre;
    }
   
}

