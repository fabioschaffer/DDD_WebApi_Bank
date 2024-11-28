using Application.Interface.Generic;
using Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface;
public interface IPersonApp : IGenericApp<Person> {
    Task Add(Person person);
    Task Update(Person person);
    Task<List<Person>> List();
}