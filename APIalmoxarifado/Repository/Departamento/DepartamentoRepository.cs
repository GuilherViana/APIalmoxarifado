using APIalmoxarifado.Infraestrutura;
using APIalmoxarifado.Model;
using APIalmoxarifado.Model.Descrição;

namespace APIalmoxarifado.Repository
{
    public class DepartamentoRepository : IDepartamentoRepository
    {
        ConexaoSQL bdConexao = new ConexaoSQL();

        public void Add(Departamento departamento)
        {
            bdConexao.Add(departamento);

        }
        public List<Departamento> GetAll()
        {

            return bdConexao.Departamento.ToList();

        }
    }
}
