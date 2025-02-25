using AngularApi.Models;
using System.Runtime.CompilerServices;

namespace AngularApi.Endpoints
{
    public static class PersonEndpoints
    {
        public static List<Person> People = new List<Person>
        {
            new Person(Guid.NewGuid(), "Teste1"),
            new Person(Guid.NewGuid(), "Teste2"),
            new Person(Guid.NewGuid(), "Teste3")
        };
        public static void MapPersonEndpoints (this WebApplication app)
        {
            //Return all people
            app.MapGet("people", () => People );

            //Return a specific person
            app.MapGet("people/{name}",
                (string name) => People.Find(x => x.Name == name));

            //Post person
            app.MapPost("people",
                (Person person) =>
                {
                    People.Add(person);
                    return person;
                });

            //Edit person's name
            app.MapPut("people/{id}", (Guid id, Person person) =>
            {
                var found = People.Find(x => x.Id == id);

                if (found == null) return Results.NotFound();

                found.Name = person.Name;

                return Results.Ok(found);
            });
        }
    }
}
