using API_aula1.Helpers;
using API_aula1.Models;

namespace API_aula1.Repositories.Contratcs
{
    public interface IPalavraRepository
    {
        ListPagination<Palavra> ObterPalavras(PalavraUrlQuery query);

        Palavra Obter(int id);

        void Cadastrar(Palavra palavra);

        void Atualizar(Palavra palavra);

        void Deletar(int id);


    }
}
