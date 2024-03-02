using APIalmoxarifado.Model;
using APIalmoxarifado.Model.Descrição;

namespace APIalmoxarifado.Repository
{
        public interface ICategoriaRepository
        {
         List<Categoria> GetAll();

        void Add(Categoria categoria);


        }
    
}
