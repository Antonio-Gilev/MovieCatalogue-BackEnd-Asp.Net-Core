using MC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MC.Service.Interface
{
    public interface IGenreService
    {
        void CreateNewGenre(Genre m);
        List<Genre> GetAllGenres();
        Genre GetGenre(Guid? id);
        void UpdateGenre(Genre m);
        void DeleteGenre(Guid? id);
    }
}
