using APIalmoxarifado.Infraestrutura;
using APIalmoxarifado.Model;

namespace APIalmoxarifado.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        ConexaoSQL bdConexao = new ConexaoSQL();

        public void Add( Produto produto )
        {
            bdConexao .Add( produto );  

        }
        public List<Produto> GetAll()
        {
        
          return bdConexao.Produto.ToList();    

        }
    }
}
