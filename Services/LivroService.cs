using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BibliotecaApi.Data;
using BibliotecaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaApi.Services
{
    public class LivroService
    {
        private readonly BibliotecaContext _context;

        public LivroService(BibliotecaContext context)
        {
            _context = context;
        }

        // Pesquisa livros por título (contém a palavra)
        public async Task<List<Livro>> PesquisarPorTituloAsync(string titulo)
        {
            return await _context.Livros
                .Where(l => l.Titulo.Contains(titulo))
                .ToListAsync();
        }

        // Pesquisa livros por autor exato
        public async Task<List<Livro>> PesquisarPorAutorAsync(string autor)
        {
            return await _context.Livros
                .Where(l => l.Autor == autor)
                .ToListAsync();
        }

        // Pesquisa livros publicados depois de um ano específico
        public async Task<List<Livro>> PesquisarPorAnoPublicacaoMaiorQueAsync(int ano)
        {
            return await _context.Livros
                .Where(l => l.Ano > ano)
                .ToListAsync();
        }

        // Pesquisa combinada: título e autor
        public async Task<List<Livro>> PesquisarPorTituloEAutorAsync(string titulo, string autor)
        {
            return await _context.Livros
                .Where(l => l.Titulo.Contains(titulo) && l.Autor == autor)
                .ToListAsync();
        }
    }
}
