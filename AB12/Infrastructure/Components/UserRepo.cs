using AB12.Domain.Base.Schema;
using AB12.Domain.Persistence;
using AB12.Infrastructure.Components.Common;
using TanvirArjel.Extensions.Microsoft.DependencyInjection;

namespace AB12.Infrastructure.Components;

[ScopedService]
public class UserRepo : BaseRepo<User>
{
  private readonly AppDbContext _context;
  public UserRepo(AppDbContext context) : base(context)
  {
    _context = context;
  }

  // custom methods here
}