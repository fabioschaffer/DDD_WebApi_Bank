using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.Generic;
public interface IGenericApp<T> where T : class {
    Task Add(T Object);
    Task Update(T Object);
    Task Delete(T Object);
    Task<T> FindById(int Id);
    Task<List<T>> List();
}