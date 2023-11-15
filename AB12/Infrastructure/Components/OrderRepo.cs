using AB12.Domain.Base.Schema;
using AB12.Domain.Persistence;
using AB12.Infrastructure.Components.Common;
using TanvirArjel.Extensions.Microsoft.DependencyInjection;

namespace AB12.Infrastructure.Components
{
    [ScopedService]
    public class ProductItemRepo : BaseRepo<Order>
    {
        private readonly AppDbContext _context;
        public ProductItemRepo(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
