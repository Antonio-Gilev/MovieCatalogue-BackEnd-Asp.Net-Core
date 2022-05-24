using MC.Domain.Models;
using MC.Domain.Relations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MC.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }

        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }

        public virtual DbSet<Roles> Roles { get; set; }

        public virtual DbSet<MovieGenres> MovieGenres { get; set; }
        public virtual DbSet<PeopleOnMovie> PeopleOnMovies { get; set; }
        public virtual DbSet<PersonHasRoles> PersonHasRoles { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Movie>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<Person>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<Genre>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<MovieGenres>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<PeopleOnMovie>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<Roles>()
                .HasKey(z => z.Id);
                

            builder.Entity<MovieGenres>()
               .HasOne(z => z.Movie)
               .WithMany(z => z.MovieGenres)
               .HasForeignKey(z => z.MovieId);

            builder.Entity<MovieGenres>()
              .HasOne(z => z.Genre)
              .WithMany(z => z.MovieGenres)
              .HasForeignKey(z => z.GenreId);

            builder.Entity<PeopleOnMovie>()
              .HasOne(z => z.Movie)
              .WithMany(z => z.PeopleOnMovie)
              .HasForeignKey(z => z.MovieId);

            builder.Entity<PeopleOnMovie>()
              .HasOne(z => z.Person)
              .WithMany(z => z.PeopleOnMovie)
              .HasForeignKey(z => z.PersonId);

            builder.Entity<PersonHasRoles>()
              .HasOne(z => z.Person)
              .WithMany(z => z.Roles)
              .HasForeignKey(z => z.PersonId);

            builder.Entity<PersonHasRoles>()
              .HasOne(z => z.Role)
              .WithMany(z => z.PeopleWithRoles)
              .HasForeignKey(z => z.RoleId);


        }

    }
}
