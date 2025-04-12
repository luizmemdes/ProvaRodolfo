namespace MinhaAgenda.Views.Controls;

public partial class ObsControls : ContentView
{
    public event EventHandler<string> OnError;
    public event EventHandler<EventArgs> OnSave;

    public ObsControls()
    {
        InitializeComponent();
    }

    public string Nome => nomeEntry.Text;
    public string Endereco => enderecoEntry.Text;
    public string Obs
    {
        get => obsName.Text;
        set => obsName.Text = value;
    }

    private void btnSave_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(Nome) ||
            string.IsNullOrWhiteSpace(Endereco) ||
            string.IsNullOrWhiteSpace(Obs))
        {
            OnError?.Invoke(this, "Todos os campos são obrigatórios.");
            return;
        }

        obsValidator.IsVisible = false;
        OnSave?.Invoke(this, EventArgs.Empty);
    }
}
