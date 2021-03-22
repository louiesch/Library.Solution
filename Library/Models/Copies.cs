using System.Collections.Generic;

namespace Library.Models
{
  public class Copies 
  {
    public Copies()
    {
      JoinEntities2 = new HashSet<BookCopies>();
    }
    public int CopiesId {get; set;}
    public string DueDate {get; set;}
    public virtual ApplicationUser User {get; set;} //patrons
    public virtual ICollection<BookCopies> JoinEntities2 {get; set;}
  }
}