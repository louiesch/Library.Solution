using System.Collections.Generic;

namespace Library.Models
{
  public class Book
  {
    public Book()
    {
      JoinEntities1 = new HashSet<AuthorBook>();
      JoinEntities2 = new HashSet<BookCopies>();
    }

    public int BookId {get; set;}
    public string Title {get; set;}
    public virtual ICollection<AuthorBook> JoinEntities1 {get;}
    public virtual ICollection<BookCopies> JoinEntities2 {get; }
  }
}