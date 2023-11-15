using AB12.Domain.Base.Common;

namespace AB12.Domain.Base.Schema;
public class User : AuditableEntity
{
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public string Email { get; set; }
  public string Password { get; set; }
  public virtual ICollection<Order> Orders { get; set; }
}
