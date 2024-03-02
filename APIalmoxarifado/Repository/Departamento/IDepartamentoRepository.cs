using APIalmoxarifado.Model;
using APIalmoxarifado.Model.Descrição;

namespace APIalmoxarifado.Repository
{
    public interface IDepartamentoRepository
    {
        List<Departamento> GetAll();

        void Add(Departamento departamento);

    }
}
