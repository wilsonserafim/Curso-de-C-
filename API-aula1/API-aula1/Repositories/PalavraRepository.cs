using API_aula1.Database;
using API_aula1.Helpers;
using API_aula1.Models;
using API_aula1.Repositories.Contratcs;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace API_aula1.Repositories
{
    public class PalavraRepository : IPalavraRepository
    {
        private readonly MimicContext _banco;
        public PalavraRepository(MimicContext banco)
        {
            _banco = banco;
        }
        public ListPagination<Palavra> ObterPalavras(PalavraUrlQuery query)
        {
            var lista = new ListPagination<Palavra>();
            var item = _banco.Palavras.AsNoTracking().AsQueryable();
            if (query.Data.HasValue)
            {
                item = item.Where(a => a.Criado >= query.Data.Value || a.Atualizacao >= query.Data.Value);
            }
            if (query.PagNumero.HasValue)
            {
                var quantidadeTotalRegistros = item.Count();
                item = item.Skip((query.PagNumero.Value - 1) * query.QtdRegistroPag.Value).Take(query.QtdRegistroPag.Value);

                var paginacao = new Paginacao();
                paginacao.NumeroPagina = query.QtdRegistroPag.Value;
                paginacao.RegistrosPorPagina = query.QtdRegistroPag.Value;
                paginacao.TotalRegistros = quantidadeTotalRegistros;
                paginacao.TotalPaginas = (int)Math.Ceiling((double)quantidadeTotalRegistros / query.QtdRegistroPag.Value);
                lista.Paginacao = paginacao;
            }
            lista.AddRange(item.ToList());
            return lista;
        }
        public Palavra Obter(int id)
        {
            return _banco.Palavras.AsNoTracking().FirstOrDefault(a => a.Id == id);
        }
        public void Cadastrar(Palavra palavra)
        {
            _banco.Palavras.Add(palavra);
            _banco.SaveChanges();
        }
        public void Atualizar(Palavra palavra)
        {
            _banco.Palavras.Update(palavra);
            _banco.SaveChanges();
        }

        public void Deletar(int id)
        {
            var palavra = Obter(id);
            palavra.Ativo = false;
            _banco.Palavras.Update(palavra);
            _banco.SaveChanges();
        }
    }
}
