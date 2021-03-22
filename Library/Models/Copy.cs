using System.Collections.Generic;

namespace Library.Models
{
  public class Copy
  {
    public Copy()
    {
      JoinEntities2 = new HashSet<BookCopy>();
    }
    public int CopyId {get; set;}
    public string DueDate {get; set;}
    public virtual ApplicationUser User {get; set;} //patrons
    public virtual ICollection<BookCopy> JoinEntities2 {get; set;}
  }
}