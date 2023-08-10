using System.Linq;
using HotChocolate;
using HotChocolate.Data;
using SuperHeroApi.Models;

namespace SuperHeroApi.Data
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Superhero> GetSuperheroes([Service] ApplicationDbContext context) =>
            context.Superheroes;
    }
}
