using Contatos.Maui.Models;
using Microsoft.Maui.Controls;
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
        searchContacts.Text = string.Empty;
        RefreshListItems();
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

    private void btnAdd_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AddContacts));
    }

    private void MenuItem_Clicked(object sender, EventArgs e)
    {
        var menuItem = sender as MenuItem;
        var contact = menuItem.CommandParameter as Contato;

        ContactRepository.DeleteContact(contact.ContactId);

        RefreshListItems();
    }
    private void RefreshListItems()
    {
        var contatos = new ObservableCollection<Contato>(ContactRepository.GetContatos());
        list.ItemsSource = contatos;
    }

    private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
    {
        var contacts = new ObservableCollection<Contato>(ContactRepository.SearchContacts(((SearchBar)sender).Text));
        list.ItemsSource = contacts;
    }
}