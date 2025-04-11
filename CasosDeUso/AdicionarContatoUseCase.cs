using CasosDeUso.Interface;
using CasosDeUso.PluginsInterfaces;
using CoreBusiness.Entidades;

namespace CasosDeUso
{

    public class AdicionarContatoUseCase : IAdicionarContatoUseCase
    {
        private readonly IRepositorioDeContatos _contatosRepository;

        public AdicionarContatoUseCase(IRepositorioDeContatos obsRepository)
        {
            _contatosRepository = obsRepository;
        }

        public async Task ExecutaAsync(Contato contato)
        {
            await _contatosRepository.AdicionarContato(contato);
        }
    }
}
