namespace Contatos.Maui.Views;

public partial class AddContacts : ContentPage
{
	public AddContacts()
	{
		InitializeComponent();
	}
    private void btnCancel_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
}