namespace MinhaAgenda.Views.Controls;

public partial class ObsControls : ContentView
{
    public event EventHandler<string> OnError;
    public event EventHandler<EventArgs> OnSave;
    public ObsControls()
	{
		InitializeComponent();
	}

    public string Obs { get { return obsName.Text; } set { obsName.Text = value; } }

    private void btnSave_Clicked(object sender, EventArgs e)
    {
         if (obsValidator.IsNotValid)
        {
            OnError?.Invoke(sender, "Uma observação é obrigatória");
            return;
        }
        OnSave?.Invoke(sender, e);
    }
}