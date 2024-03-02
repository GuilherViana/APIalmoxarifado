using APIalmoxarifado.Model;
using APIalmoxarifado.Model.Descrição;
using APIalmoxarifado.Repository;
using APIalmoxarifado.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace APIalmoxarifado.Controllers
{
    [ApiController]
    [Route("api/v1/categoria")]
    public class CategoriaController : ControllerBase
    {
        private readonly CategoriaRepository _categoriaRepository;




        public CategoriaController(CategoriaRepository Repository)
        {
            _categoriaRepository = Repository;
        }



        [HttpGet]
        [Route("GetAllFake")]
        public IActionResult GetAllFake()
        {
            var categorias = new List<Categoria>()
            {
                new Categoria()
                {
                    id = 1,
                    descricao = "Categoria 1",

                },
                new Categoria()
                {
                    id = 1,
                    descricao = "Categoria 2",
                }
            };
            return Ok(categorias);
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_categoriaRepository.GetAll());
        }
    }
   
}
