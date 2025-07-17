using FH1Repository.Interface;
using FH1Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace FH1Repository.Implementation;

public class Repository<T> : IRepository<T> where T : class
{
    protected readonly DemoProjContext _context;
    protected readonly DbSet<T> _dbSet;

    public Repository(DemoProjContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<T?> GetByIdAsync(object id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
    }

    public void Update(T entity)
    {
        _dbSet.Update(entity);
    }

    public void Delete(T entity)
    {
        _dbSet.Remove(entity);
    }

    public async Task<bool> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }
}
