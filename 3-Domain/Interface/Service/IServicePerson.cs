using Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface.Service;
public interface IServicePerson {
    Task Add(Person person);
    Task Update(Person person);
    Task<List<Person>> List();
}