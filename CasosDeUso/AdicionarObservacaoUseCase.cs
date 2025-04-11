using CasosDeUso.Interface;
using CasosDeUso.PluginsInterfaces;
using CoreBusiness.Entidades;

namespace CasosDeUso
{

    public class AdicionarObservacaoUseCase : IAdicionarObsUseCase
    {
        private readonly IRepositorioDeObs _observacaoRepository;

        public AdicionarObservacaoUseCase(IRepositorioDeObs _observacaoRepository)
        {
            this._observacaoRepository = _observacaoRepository;
        }

        public async Task ExecutaAsync(Obs obs)
        {
            await _observacaoRepository.AdicionarObs(obs);
        }
    }
}
