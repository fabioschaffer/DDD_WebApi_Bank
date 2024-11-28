using Application.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Entity.Entity;

namespace _1_WebApi.Endpoint.Person;

public class PersonPost {
    public static string Route => "/person";
    public static string[] Method => new string[] { HttpMethod.Post.ToString() };
    public static Delegate Handle => Action;

    public static async Task<IResult> Action(IPersonApp personApp, [FromQuery] int id, [FromQuery] int cpf, [FromQuery] string name) {

        var person = new Entity.Entity.Person();
        person.Id = id;
        person.CPF = cpf;
        person.Name = name;
        await personApp.Add(person);

        return Results.Created($"/product/{id}", id);
    }
}