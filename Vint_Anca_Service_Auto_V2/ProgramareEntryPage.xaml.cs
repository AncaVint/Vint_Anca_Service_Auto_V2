namespace Vint_Anca_Service_Auto_V2;
using Vint_Anca_Service_Auto_V2.Data;
using Vint_Anca_Service_Auto_V2.Models;

public partial class ProgramareEntryPage : ContentPage
{
    public ProgramareEntryPage()
    {
        InitializeComponent();
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.ProgramareDatabase.GetProgramariAsync();
    }
    async void OnProgramareAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ProgramarePage
        {
            BindingContext = new Programare()
        });
    }
    async void OnProgramareViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new ProgramarePage
            {
                BindingContext = e.SelectedItem as Programare
            });
        }
    }
}