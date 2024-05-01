namespace Contatos.Maui.Views;

public partial class EditContacts : ContentPage
{
	public EditContacts()
	{
		InitializeComponent();
	}

    private void btnCancel_Clicked(object sender, EventArgs e)
    {
        Console.WriteLine("Click");
        Shell.Current.GoToAsync($"//{nameof(ContactsPage)}");
    }
}