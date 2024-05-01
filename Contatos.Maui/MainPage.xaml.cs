namespace Contatos.Maui
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            CounterBtn.Text=($"Clicou {count} vezes");
            SemanticScreenReader.Announce(CounterBtn.Text);
        }
        private void OnResetClicked(object sender, EventArgs e)
        {
            CounterBtn.Text=($"Clicou {count = 0} vezes");
        }
    }

}
