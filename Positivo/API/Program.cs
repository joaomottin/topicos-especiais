using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Namespace;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Curso> cursos = new List<Curso>() {
    new Curso(){Id = 1, Name = "Ciência da Computação "},
    new Curso(){Id = 2, Name = "Medicina"}
};

app.MapGet("/", () => {
    return Results.Ok(cursos);
});

app.MapGet("/{id}", ([FromRoute] int id) => {
    return Results.Ok(cursos.Find(curso => curso.Id == id));
});

app.MapPost("/", ([FromBody] Curso curso) => {
    cursos.Add(curso);
    return Results.Ok(curso);
});


app.Run();
