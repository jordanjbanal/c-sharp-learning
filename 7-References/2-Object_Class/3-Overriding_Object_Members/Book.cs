namespace TheObjectClass
{
  class Book
  {
    public string Author
    { get; private set; }
    
    public string Title
    { get; private set; }

    public Book(string author = "Unknown", string title = "Untitled")
    {
      Author = author;
      Title = title;
    }

    public virtual string Stringify()
    {
      return "This is a Book object!";
    }

    public override string ToString()
    {
      return $"The author is: {Author} and the title is: {Title}";
    }
  }
}