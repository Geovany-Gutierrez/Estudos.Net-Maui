using Contatos.Maui.Models;
using Microsoft.Maui.ApplicationModel.Communication;
using System.Security.Cryptography.X509Certificates;

namespace Contatos.Maui.Views;

public partial class AddContacts : ContentPage
{
    private Contato contact;
	public AddContacts()
	{
		InitializeComponent();
	}
    private void btnCancel_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"//{nameof(ContactsPage)}");
    }

    private void ContactControl_OnSave(object sender, EventArgs e)
    {
        var InputName = contactCtrl.Name;
        var InputEmail = contactCtrl.Email;
        var InputPhone = contactCtrl.Phone;
        var InputAddress = contactCtrl.Address;
        
        Contato _contato = new Contato() { 
            Name = InputName, 
            Email = InputEmail, 
            Phone = InputPhone,
            Address = InputAddress,
            };
        ContactRepository.AddContact(_contato);
        Shell.Current.GoToAsync($"//{nameof(ContactsPage)}");
    }

    private void ContactControl_OnError(object sender, string e)
    {
       DisplayAlert("Erro", e.ToString(), "Ok");
    }
}