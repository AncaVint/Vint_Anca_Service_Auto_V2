namespace Vint_Anca_Service_Auto_V2;
using Vint_Anca_Service_Auto_V2.Models;
public partial class ProgramarePage : ContentPage
{
    public ProgramarePage()
    {
        InitializeComponent();
    }
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var programare = (Programare)BindingContext;
        await App.ProgramareDatabase.SaveProgramareAsync(programare);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var programare = (Programare)BindingContext;
        await App.ProgramareDatabase.DeleteProgramareAsync(programare);
        await Navigation.PopAsync();
    }
}