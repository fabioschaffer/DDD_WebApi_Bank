using Application.Interface;
using Domain.Interface.Generic;
using Domain.Interface.Service;
using Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.App;
public class PersonApp : IPersonApp {

    IServicePerson _IServicePerson;

    public PersonApp(IGeneric<Person> IPerson, IServicePerson IServicePerson) {
        _IServicePerson = IServicePerson;
    }

    public async Task Add(Person person) {
        await _IServicePerson.Add(person);
    }

    public async Task Update(Person person) {
        await _IServicePerson.Update(person);
    }

    public async Task<List<Person>> List() {
        return await _IServicePerson.List();
    }

    public Task Delete(Person Object) => throw new NotImplementedException();
    public Task<Person> FindById(int Id) => throw new NotImplementedException();
}