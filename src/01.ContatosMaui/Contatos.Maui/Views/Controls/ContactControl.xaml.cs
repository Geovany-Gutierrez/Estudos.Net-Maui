using Contatos.Maui.Models;
namespace Contatos.Maui.Views.Controls;

public partial class ContactControl : ContentView
{
    public event EventHandler<string> OnError;
	public event EventHandler<EventArgs> OnSave;
	public event EventHandler<EventArgs> OnCancel;

    private Contato contact;
	public ContactControl()
	{
		InitializeComponent();
	}

	public string Name
	{
		get
		{
			return lblName.Text;
		}
		set
		{
			lblName.Text = value;
		}
	}
	public string Email
	{
		get
		{
			return lblEmail.Text;
		}
		set
		{
			lblEmail.Text = value;
		}
	}
	public string Phone
	{
		get
		{ 
			return lblPhone.Text;
		}
		set
		{
			lblPhone.Text = value;
		}
	}
	public string Address
	{
		get
		{
			return lblAddress.Text;
		}
		set
		{
			lblAddress.Text = value;
		}
	}

    private void btnSave_Clicked(object sender, EventArgs e)
    {
        if (nameValidator.IsNotValid)
        {
			OnError ? .Invoke(sender, "Nome é obrigatório.");
			return;
        }
        if (emailValidator.IsNotValid)
        {
            foreach (var error in emailValidator.Errors)
            {
				OnError?.Invoke(sender, error.ToString());
				return;
            }
        }

		OnSave?.Invoke(sender, e);
    }
    private void btnCancel_Clicked(object sender, EventArgs e)
    {
		OnCancel?.Invoke(sender, e);
    }
}