using clen_code_project.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace clen_code_project.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<TodoList> TodoLists { get; set; }

        DbSet<TodoItem> TodoItems { get; set; }

        DbSet<Student> Students { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
