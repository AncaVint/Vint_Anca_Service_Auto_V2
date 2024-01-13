namespace Vint_Anca_Service_Auto_V2;
using System.Net.Mail;
using System.Net;
using Vint_Anca_Service_Auto_V2.Data;
using Vint_Anca_Service_Auto_V2.Models;

public partial class ClientEntryPage : ContentPage
{
    public ClientEntryPage()
    {
        InitializeComponent();
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.ClientDatabase.GetClientiAsync();
    }
    async void OnClientAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ClientiPage
        {
            BindingContext = new Client()
        });
    }
    async void OnClientViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new ClientiPage
            {
                BindingContext = e.SelectedItem as Client
            });
        }
    }


    async void OnTrimiteNotificareClicked(object sender, EventArgs e)
    {
        Console.WriteLine("Butonul Trimite notificare a fost apăsat!");

        if (sender is Button button && button.BindingContext is Client client)
        {
            Console.WriteLine($"Client selectat: {client.Nume} {client.Prenume}");

            if (!string.IsNullOrWhiteSpace(client.Email))
            {
                var emailMessage = new EmailMessage
                {
                    Subject = "Subiect notificare",
                    Body = "Corpul notificării",
                    To = new List<string> { client.Email }
                };

                try
                {
                    Console.WriteLine("Trimitere email în curs...");
                    await Email.ComposeAsync(emailMessage);
                    Console.WriteLine("Email trimis cu succes!");
                }
                catch (FeatureNotSupportedException)
                {
                    Console.WriteLine("Eroare: Funcționalitatea de trimitere a email-ului nu este suportată pe acest dispozitiv.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Eroare: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Eroare: Adresa de email a clientului este goală sau nulă.");
            }
        }
    }


}