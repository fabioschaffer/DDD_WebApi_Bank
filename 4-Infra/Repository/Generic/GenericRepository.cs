using Domain.Interface.Generic;
using Entity.Entity;
using Infra.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repository.Generic;
public class GenericRepository<T> : IGeneric<T>, IDisposable where T : class {

    public async Task Add(T Objeto) {
        using (var data = new AppDbContext()) {
            await data.Set<T>().AddAsync(Objeto);
            await data.SaveChangesAsync();

            //var person = new Person() { Id = 1, CPF = 1, Name = "a" };
            //await data.Set<Person>().AddAsync(person);
            //await data.SaveChangesAsync();
        }
    }

    public async Task Update(T Objeto) {
        using (var data = new AppDbContext()) {
            data.Set<T>().Update(Objeto);
            await data.SaveChangesAsync();
        }
    }

    public async Task<T> FindById(int Id) {
        using (var data = new AppDbContext()) {
            return await data.Set<T>().FindAsync(Id);
        }
    }

    public async Task Delete(T Objeto) {
        using (var data = new AppDbContext()) {
            data.Set<T>().Remove(Objeto);
            await data.SaveChangesAsync();
        }
    }

    public async Task<List<T>> List() {
        using (var data = new AppDbContext()) {
            return await data.Set<T>().AsNoTracking().ToListAsync();
        }
    }

    #region Disposed https://docs.microsoft.com/pt-br/dotnet/standard/garbage-collection/implementing-dispose
    // Flag: Has Dispose already been called?
    bool disposed = false;
    // Instantiate a SafeHandle instance.
    SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);


    // Public implementation of Dispose pattern callable by consumers.
    public void Dispose() {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    // Protected implementation of Dispose pattern.
    protected virtual void Dispose(bool disposing) {
        if (disposed)
            return;

        if (disposing) {
            handle.Dispose();
            // Free any other managed objects here.
            //
        }

        disposed = true;
    }
    #endregion
}