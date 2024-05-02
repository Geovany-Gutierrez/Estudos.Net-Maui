using Contatos.Maui.Models;
using System.Collections.ObjectModel;
using Contato = Contatos.Maui.Models.Contato;
namespace Contatos.Maui.Views;
public partial class ContactsPage : ContentPage
{
    public ContactsPage()
    {
        InitializeComponent();
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        var contatos = new ObservableCollection<Contato>(ContactRepository.GetContatos());
        list.ItemsSource = contatos;
    }
    private async void list_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (list.SelectedItem != null)
        {

            await Shell.Current.GoToAsync($"{nameof(EditContacts)}?Id={((Contato)list.SelectedItem).ContactId}");      
        }
        //logic
    }

    private void list_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        list.SelectedItem = null;
    }
}