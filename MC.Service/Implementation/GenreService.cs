using MC.Domain.Models;
using MC.Repository.Interface;
using MC.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MC.Service.Implementation
{
    public class GenreService : IGenreService
    {
        private readonly IRepository<Genre> genreRepository;

        public GenreService(IRepository<Genre> genreRepository)
        {
            this.genreRepository = genreRepository;
        }

        public void CreateNewGenre(Genre m)
        {
            this.genreRepository.Insert(m);
        }

        public void DeleteGenre(Guid? id)
        {
            var genre = this.GetGenre(id);
            this.genreRepository.Delete(genre);
        }

        public List<Genre> GetAllGenres()
        {
            return this.genreRepository.GetAll().ToList();
        }

        public Genre GetGenre(Guid? id)
        {
            return this.genreRepository.Get(id);
        }

        public void UpdateGenre(Genre m)
        {
            this.genreRepository.Update(m);
        }
    }
}
