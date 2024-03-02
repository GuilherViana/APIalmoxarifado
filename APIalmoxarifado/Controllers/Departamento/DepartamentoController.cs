using APIalmoxarifado.Model.Descrição;
using APIalmoxarifado.Repository;
using Microsoft.AspNetCore.Mvc;

namespace APIalmoxarifado.Controllers
{
    [ApiController]
    [Route("api/v1/departamento")]
    public class DepartamentoController : ControllerBase
    {
        private readonly DepartamentoRepository _departamentoRepository;




        public DepartamentoController(DepartamentoRepository Repository)
        {
            _departamentoRepository = Repository;
        }



        [HttpGet]
        [Route("GetAllFake")]
        public IActionResult GetAllFake()
        {
            var departamento = new List<Departamento>()
            {
                new Departamento()
                {
                    id = 1,
                    descricao = "laticinios 1",

                },
                new Departamento()
                {
                    id = 1,
                    descricao = "laticinios 2",
                }
            };
            return Ok(departamento);
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_departamentoRepository.GetAll());
        }
    }

}
