using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebFilmes.Data;
using System;
using System.Linq;

namespace WebFilmes.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new ApplicationDbContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<ApplicationDbContext>>()))
        {
            // Look for any movies.
            if (context.Movies.Any())
            {
                return;   // DB has been seeded
            }
            context.Movies.AddRange(
                new Movie
                {
                    Title = "Um Sonho de Liberdade",
                    ReleaseYear = 1994,
                    Genre = "Drama",
                    Director = "Frank Darabont",
                    Synopsis = "Dois homens presos desenvolvem uma amizade ao longo dos anos, encontrando redenção por meio de atos de decência comum."
                },
                new Movie
                {
                    Title = "O Poderoso Chefão",
                    ReleaseYear = 1972,
                    Genre = "Crime",
                    Director = "Francis Ford Coppola",
                    Synopsis = "O patriarca envelhecido de uma dinastia do crime organizado transfere o controle de seu império clandestino para seu filho relutante."
                },
                new Movie
                {
                    Title = "A Origem",
                    ReleaseYear = 2010,
                    Genre = "Ficção Científica",
                    Director = "Christopher Nolan",
                    Synopsis = "Um ladrão que rouba segredos corporativos por meio da tecnologia de compartilhamento de sonhos recebe a tarefa de plantar uma ideia na mente de um CEO."
                },
                new Movie
                {
                    Title = "O Cavaleiro das Trevas",
                    ReleaseYear = 2008,
                    Genre = "Ação",
                    Director = "Christopher Nolan",
                    Synopsis = "Quando o vilão conhecido como o Coringa emerge de seu passado misterioso, ele semeia caos e destruição nas pessoas de Gotham. O Cavaleiro das Trevas deve enfrentar um dos maiores testes psicológicos e físicos de sua habilidade para combater a injustiça."
                },
                new Movie
                {
                    Title = "O Senhor dos Anéis: A Sociedade do Anel",
                    ReleaseYear = 2001,
                    Genre = "Aventura",
                    Director = "Peter Jackson",
                    Synopsis = "Um jovem hobbit, Frodo, que encontrou o Um Anel que pertence ao Senhor Sauron, inicia sua jornada até a Montanha da Perdição, o único lugar onde ele pode ser destruído."
                },
                new Movie
                {
                    Title = "Avatar",
                    ReleaseYear = 2009,
                    Genre = "Ficção Científica",
                    Director = "James Cameron",
                    Synopsis = "Um Marine paraplégico enviado à lua Pandora em uma missão única fica dividido entre seguir suas ordens e proteger o mundo que ele considera sua casa."
                }
            );
            context.SaveChanges();
        }
    }
}