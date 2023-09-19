using Final.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Final.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }

    DbSet<NguoiDung> NguoiDungs { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
