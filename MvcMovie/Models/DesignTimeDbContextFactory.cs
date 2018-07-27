using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MvcMovie.Models;

namespace MvcMovie
{
   

    public class MvcMovieDbContextFactory : IDesignTimeDbContextFactory<MvcMovieContext>
    {
        public MvcMovieContext CreateDbContext(string[] args)
        {
            var connection = "Server=localhost,1433;Database=MvcMovie;User ID=SA;Password='Sal1234!';";
            var builder = new DbContextOptionsBuilder<MvcMovieContext>();
            builder.UseSqlServer(connection,
                                 optionsBuilder => optionsBuilder.MigrationsAssembly(typeof(MvcMovieContext).GetTypeInfo().Assembly.GetName().Name));

            return new MvcMovieContext(builder.Options);
        }
    }
}