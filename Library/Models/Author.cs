using System.Collections.Generic;

namespace Library.Models
{
public class Author
{
  public Author()
  {
    JoinEntities1 = new HashSet<AuthorBook>();
  }

  public int AuthorId { get; set;}
  public string Name {get; set;}  public virtual ICollection<AuthorBook> JoinEntities1 { get; set;}

  }
}
