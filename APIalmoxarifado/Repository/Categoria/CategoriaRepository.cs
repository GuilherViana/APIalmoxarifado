using APIalmoxarifado.Infraestrutura;
using APIalmoxarifado.Model;
using APIalmoxarifado.Model.Descrição;

namespace APIalmoxarifado.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        ConexaoSQL bdConexao = new ConexaoSQL();

        public void Add(Categoria categoria)
        {
            bdConexao.Add(categoria);
        }

        public List<Categoria> GetAll()
        {
            return bdConexao.Categoria.ToList();
        }

    
    }
}
