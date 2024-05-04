using Contatos.Maui.Views;

namespace Contatos.Maui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ContactsPage), typeof(ContactsPage));
            Routing.RegisterRoute(nameof(EditContacts), typeof(EditContacts));
            Routing.RegisterRoute(nameof(AddContacts), typeof(AddContacts));
        }
    }
}
