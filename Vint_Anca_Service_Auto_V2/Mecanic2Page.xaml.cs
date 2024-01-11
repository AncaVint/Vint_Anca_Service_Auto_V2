namespace Vint_Anca_Service_Auto_V2;
using Vint_Anca_Service_Auto_V2.Models;
public partial class Mecanic2Page : ContentPage
{
    public Mecanic2Page()
    {
        InitializeComponent();
    }
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var mecanic = (Mecanic)BindingContext;
        await App.Database.SaveMecanicAsync(mecanic);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var mecanic = (Mecanic)BindingContext;
        await App.Database.DeleteMecanicAsync(mecanic);
        await Navigation.PopAsync();
    }
}