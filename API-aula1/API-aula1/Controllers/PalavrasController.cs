using API_aula1.Database;
using API_aula1.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_aula1.Controllers
{
    [ApiController]
    [Route("api/palavras")]
    public class PalavrasController : Controller
    {
        private readonly MimicContext _banco;

        public PalavrasController(MimicContext banco)
        {
            _banco = banco;
        }

        //-- /api/palavras?data=2023-06-20
        [Route("")]
        [HttpGet]
        public ActionResult ObterTodas(DateTime? data, int? pagNumero, int? qtdRegistroPag)
        {
            var item = _banco.Palavras.AsQueryable();
            if (data.HasValue)
            {
                item = item.Where(a=>a.Criado >= data.Value || a.Atualizacao >= data.Value);
            }
            if (pagNumero.HasValue)
            {
                item = item.Skip((pagNumero.Value - 1) * qtdRegistroPag.Value).Take(qtdRegistroPag.Value);
            }
            return Ok(item);
        }

        //-- /api/palavras/1 (PUT: id, nome, ativo, pontuacao, criacao)
        [Route("{id}")]
        [HttpGet]
        public ActionResult Obter(int id) 
        {
            var obj = _banco.Palavras.Find(id);//criei uma variavel para procurar o dado no banco através da id e fiz um if onde checa se ele nao encontrar
            //nenhum dado ele retorna Not Found igual aqui em baixo.
            if (obj == null)
            {
                return NotFound();
            }
            return Ok();
        }

        //-- /api/palavras
        [Route("")]
        [HttpPost]
        public ActionResult Cadastrar([FromBody]Palavra palavra)
        {
            _banco.Palavras.Add(palavra);
            _banco.SaveChanges();

            return Created($"/api/palavras/{palavra.Id}", palavra);
        }

        //-- /api/palavras/1 (PUT: id, nome, ativo, pontuacao, criacao)
        [Route("{id}")]
        [HttpPut]
        public ActionResult Atualizar(int id, [FromBody]Palavra palavra)
        {
            var obj = _banco.Palavras.Find(id);//criei uma variavel para procurar o dado no banco através da id e fiz um if onde checa se ele nao encontrar
            //nenhum dado ele retorna Not Found igual aqui em baixo.
            if (obj == null)
            {
                return NotFound();
            }

            palavra.Id = id;
            _banco.Palavras.Update(palavra);
            _banco.SaveChanges();

            return NoContent();
        }

        //-- /api/palavras/1 (DELETE)
        [Route("{id}")]
        [HttpDelete]
        public ActionResult Deletar(int id)
        {

            var palavra = _banco.Palavras.Find(id);//criei uma variavel para procurar o dado no banco através da id e fiz um if onde checa se ele nao encontrar
            //nenhum dado ele retorna Not Found igual aqui em baixo.
            if (palavra == null)
            {
                return NotFound();
            }

            palavra.Ativo = false;
            _banco.Palavras.Update(palavra);
            _banco.SaveChanges();

            return NoContent();
        }
    }
}
