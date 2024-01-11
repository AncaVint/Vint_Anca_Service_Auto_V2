namespace Vint_Anca_Service_Auto_V2;
using Vint_Anca_Service_Auto_V2.Data;
using Vint_Anca_Service_Auto_V2.Models;

public partial class MecanicPage : ContentPage
{
    public MecanicPage()
    {
        InitializeComponent();
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Database.GetMecaniciAsync();
    }
    async void OnMecanicAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Mecanic2Page
        {
            BindingContext = new Mecanic()
        });
    }
    async void OnMecanicViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new Mecanic2Page
            {
                BindingContext = e.SelectedItem as Mecanic
            });
        }
    }
}