using Domain.Interface.Generic;
using Domain.Interface.Service;
using Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service;
public class PersonService : IServicePerson {

    private readonly IGeneric<Person> _IGeneric;

    public PersonService(IGeneric<Person> IGeneric) {
        _IGeneric = IGeneric;
    }


    public async Task Add(Person person) {
        //var validarTitulo = noticia.ValidarPropriedadeString(noticia.Titulo, "Titulo");
        //var validarInformacao = noticia.ValidarPropriedadeString(noticia.Informacao, "Informacao");

        //if (validarTitulo && validarInformacao) {
            //person.DataAlteracao = DateTime.Now;
            //noticia.DataCadastro = DateTime.Now;
            //noticia.Ativo = true;
            await _IGeneric.Add(person);
        //}

    }

    public async Task Update(Person person) {
        //var validarTitulo = noticia.ValidarPropriedadeString(noticia.Titulo, "Titulo");
        //var validarInformacao = noticia.ValidarPropriedadeString(noticia.Informacao, "Informacao");

        //if (validarTitulo && validarInformacao) {
        //    noticia.DataAlteracao = DateTime.Now;
        //    noticia.DataCadastro = DateTime.Now;
        //    noticia.Ativo = true;
            await _IGeneric.Update(person);
       // }
    }

    public async Task<List<Person>> List() {
        return await _IGeneric.List();
    }
}