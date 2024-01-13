namespace Vint_Anca_Service_Auto_V2;
using Vint_Anca_Service_Auto_V2.Models;
public partial class ClientiPage : ContentPage
{
    public ClientiPage()
    {
        InitializeComponent();
    }
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var client = (Client)BindingContext;
        await App.ClientDatabase.SaveClientAsync(client);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var client = (Client)BindingContext;
        await App.ClientDatabase.DeleteClientAsync(client);
        await Navigation.PopAsync();
    }
}