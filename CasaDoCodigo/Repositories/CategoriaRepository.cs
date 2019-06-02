using CasaDoCodigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositories
{
    public interface ICategoriaRepository
    {
        Task<Categoria> SaveCategoria(string nome);
    }

    public class CategoriaRepository : BaseRepository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public async Task<Categoria> SaveCategoria(string nome)
        {
            var categoriaDB = dbSet
                .Where(c => c.Nome == nome)
                .SingleOrDefault();

            if (categoriaDB == null)
            {
                var saveCategoria = new Categoria()
                {
                    Nome = nome
                };

                categoriaDB = dbSet.Add(saveCategoria).Entity;
            }

            await contexto.SaveChangesAsync();
            return categoriaDB;
        }
    }
}
