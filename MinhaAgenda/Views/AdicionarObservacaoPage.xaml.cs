using CasosDeUso.Interface;

namespace MinhaAgenda.Views;

public partial class AdicionarObservacaoPage : ContentPage
{
    private readonly IAdicionarObsUseCase _adicionarObsUseCase;

    public AdicionarObservacaoPage(IAdicionarObsUseCase adicionarObsUseCase)
	{
		InitializeComponent();
        _adicionarObsUseCase = adicionarObsUseCase;
	}

    private async void contatoCtrl_OnSave(object sender, EventArgs e)
    {
        await _adicionarObsUseCase.ExecutaAsync(new CoreBusiness.Entidades.Obs(obsCtrl.Obs));
    }

    private void contatoCtrl_OnError(object sender, string e)
    {
        DisplayAlert("Erro", e, "Ok");
    }
}