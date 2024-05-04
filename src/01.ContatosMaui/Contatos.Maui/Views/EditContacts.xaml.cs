using Contatos.Maui.Models;
using Contatos.Maui.Views.Controls;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Contatos.Maui.Views;
[QueryProperty(nameof(ContactId), "Id")]
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
            contactCtrl.Name = contact.Name;
            contactCtrl.Email = contact.Email;
            contactCtrl.Phone = contact.Phone;
            contactCtrl.Address = contact.Address;

        }
    }

    private void contactCtrl_OnSave(object sender, EventArgs e)
    {
        contact.Name = contactCtrl.Name;
        contact.Email = contactCtrl.Email;
        contact.Phone = contactCtrl.Phone;
        contact.Address = contactCtrl.Address;

        ContactRepository.UpdateContact(contact.ContactId, contact);
        Shell.Current.GoToAsync($"//{nameof(ContactsPage)}");
    }

    private void contactCtrl_OnError(object sender, string e)
    {
        DisplayAlert("Error", e, "OK");
    }
}