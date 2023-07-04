using API_aula1.Database;
using API_aula1.Helpers;
using API_aula1.Models;
using API_aula1.Repositories.Contratcs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace API_aula1.Controllers
{
    [ApiController]
    [Route("api/palavras")]
    public class PalavrasController : Controller
    {
        private readonly IPalavraRepository _repository;

        public PalavrasController(MimicContext repository)
        {
            _repository = repository;
        }

        //-- /api/palavras?data=2023-06-20
        [Route("")]
        [HttpGet]
        public ActionResult ObterTodas([FromQuery]PalavraUrlQuery query)
        {
            var item = _repository.ObterPalavras(query);
            if (query.PagNumero > item.Paginacao.TotalPaginas)
            {
                return NotFound();
            }
            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(item.Paginacao));
            return Ok(item.ToList());
        }

        //-- /api/palavras/1 (PUT: id, nome, ativo, pontuacao, criacao)
        [Route("{id}")]
        [HttpGet]
        public ActionResult Obter(int id) 
        {
            var obj = _repository.Obter(id);
           
            if (obj == null)
            {
                return NotFound();
            }
            return Ok(obj);
        }

        //-- /api/palavras
        [Route("")]
        [HttpPost]
        public ActionResult Cadastrar([FromBody]Palavra palavra)
        {
            _repository.Cadastrar(palavra);


            return Created($"/api/palavras/{palavra.Id}", palavra);
        }

        //-- /api/palavras/1 (PUT: id, nome, ativo, pontuacao, criacao)
        [Route("{id}")]
        [HttpPut]
        public ActionResult Atualizar(int id, [FromBody]Palavra palavra)
        {
            var obj = _repository.Obter(id);
            if (obj == null)
                return NotFound();
                palavra.Id = id;
                _repository.Atualizar(palavra);
            return Ok();
        }

        //-- /api/palavras/1 (DELETE)
        [Route("{id}")]
        [HttpDelete]
        public ActionResult Deletar(int id)
        {
            var palavra = _repository.Obter(id);

            if (palavra == null)
                return NotFound();

            _repository.Deletar(id);

            return NoContent();
        }
    }
}
