using APIalmoxarifado.Model;
using APIalmoxarifado.Repository;
using APIalmoxarifado.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace APIalmoxarifado.Controllers
{
    [ApiController]
    [Route("api/v1/produto")]
    public class ProdutoController : ControllerBase
    {

        private readonly ProdutoRepository _produtoRepository;
        private object _produtosRepository;

        public ProdutoController(ProdutoRepository Repository)
        {
            _produtoRepository = Repository;
        }

        [HttpGet]
        [Route("Hello")]
        public IActionResult Index()
        {
            return Ok("Hello Mundo");
        }

        [HttpGet]
        [Route("GetAllFake")]
        public IActionResult GetAllFake()
        {
            var produtos = new List<Produto>()
            {
              new Produto()
              {
                  id = 1,
                  nome="PC HP",
                  estoque=10
              },
              new Produto()
              {
                id=2,
                nome="PC DELL",
                estoque=20
              }


            };
            return Ok(produtos);
        }

        [HttpGet]
        [Route("GetAll")]

        public IActionResult GetAll()
        {

            return Ok(_produtoRepository.GetAll());

        }

        [HttpGet]
        [Route("AdicionarProdutoComFoto")]
        public IActionResult AdicionarProdutoComFoto(ProdutoViewModelComFoto produto)
        {
            try
            {
                var caminho = Path.Combine("Storage", produto.photo.FileName);
                using Stream fileStream = new FileStream(caminho, FileMode.Create);
                produto.photo.CopyTo(fileStream);

                _produtoRepository.Add(
                  new Produto() { nome = produto.nome, estoque = produto.estoque, photourl = null }
                );

                return Ok("Cadastrado com Sucesso");
            }
            catch (Exception ex)
            {

                return BadRequest("Não Cadastrado. Erro: " + ex.Message);
            }

        }

        [HttpGet]
        [Route("AdicionarProdutoSemFoto")]
        public IActionResult AdicionarProdutoSemFoto(ProdutoViewModelSemFoto produto)
        {
            try
            {
                _produtoRepository.Add(
                  new Produto() { nome = produto.nome, estoque = produto.estoque, photourl = null }
                );

                return Ok("Cadastrado com Sucesso");
            }
            catch (Exception ex)
            {

                return BadRequest("Não Cadastrado. Erro: " + ex.Message);
            }

        }
        [HttpGet]
        [Route("{id}/GetProduto")]

        public IActionResult Download(int id)
        {

            try
            {
                var produto = _produtoRepository.GetAll().Find(x => x.id == id);
                if (produto.photourl == null)
                {
                    return Ok("Não existe falta cadastrada para o Produto");
                }

                else
                {
                    var dataBytes = System.IO.File.ReadAllBytes(produto.photourl);
                    return File(dataBytes, "image/jpg");

                }
            }
            catch (Exception ex)
            {

                return BadRequest("Erro em fazer download: " + ex.Message);
            }


        }
    }
}