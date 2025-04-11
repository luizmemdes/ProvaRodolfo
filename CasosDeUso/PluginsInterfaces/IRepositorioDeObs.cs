using CoreBusiness.Entidades;

namespace CasosDeUso.PluginsInterfaces
{
    public interface IRepositorioDeObs
    {
        Task AdicionarObs(Obs obs);
    }
}
