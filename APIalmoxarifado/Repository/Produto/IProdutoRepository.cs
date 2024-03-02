using APIalmoxarifado.Model;

namespace APIalmoxarifado.Repository
{
    public interface IProdutoRepository
    {
        List<Produto> GetAll();

        void Add (Produto produto);

    }
}
