using Contatos.Maui.Models;
using Contato = Contatos.Maui.Models.Contato;
namespace Contatos.Maui.Views;
public partial class ContactsPage : ContentPage
{
    public ContactsPage()
    {
        InitializeComponent();
        List<Contato> contatos = ContactRepository.GetContatos();
        list.ItemsSource = contatos;
    }
    private async void list_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (list.SelectedItem != null)
        {
            await Shell.Current.GoToAsync($"{nameof(EditContacts)}?Id={(Contato)list.SelectedItem}");      
        }
        //logic
    }

    private void list_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        list.SelectedItem = null;
    }
}