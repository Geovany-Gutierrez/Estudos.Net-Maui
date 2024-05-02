using Contatos.Maui.Models;
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
            lblName.Text = contact.Name;
            lblEmail.Text = contact.Email;
            lblPhone.Text = contact.Phone;
            lblAddress.Text = contact.Email;

        }
    }
    private void btnUpdate_Clicked(object sender, EventArgs e)
    {
        contact.Name = lblName.Text;
        contact.Email = lblEmail.Text;
        contact.Phone = lblPhone.Text;
        contact.Address = lblAddress.Text;

        ContactRepository.UpdateContact(contact.ContactId, contact);
        Shell.Current.GoToAsync($"//{nameof(ContactsPage)}");
    }
}