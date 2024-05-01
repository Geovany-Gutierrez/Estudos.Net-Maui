using Contatos.Maui.Models;

namespace Contatos.Maui.Views;
[QueryProperty(nameof(ContactId),"Id")]
public partial class EditContacts : ContentPage
{
    private Contato contact;
	public EditContacts()
	{
		InitializeComponent();
	}

    private void btnCancel_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"//{nameof(ContactsPage)}");
    }

    public string ContactId
    {
        set
        {
            contact = ContactRepository.GetContactById(int.Parse(value));
            lblName.Text = contact.Name;
            lblEmail.Text = contact.Email;
        }
    }
}