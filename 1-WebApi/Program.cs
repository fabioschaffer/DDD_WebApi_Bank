using _1_WebApi.Endpoint.Person;
using Application.App;
using Application.Interface;
using Domain.Interface.Generic;
using Domain.Interface.Service;
using Domain.Service;
using Entity.Entity;
using Infra.Repository.Generic;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IGeneric<Person>, GenericRepository<Person>>();

builder.Services.AddSingleton<IServicePerson, PersonService>();

builder.Services.AddSingleton<IPersonApp, PersonApp>(); 


var app = builder.Build();

app.MapMethods(PersonPost.Route, PersonPost.Method, PersonPost.Handle);

app.Run();
