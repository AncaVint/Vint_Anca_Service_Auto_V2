using System;
using Vint_Anca_Service_Auto_V2.Data;
using System.IO;
namespace Vint_Anca_Service_Auto_V2;

public partial class App : Application
{
    static MecanicDatabase database;
    public static MecanicDatabase Database
    {
        get
        {
            if (database == null)
            {
                database = new
               MecanicDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
               LocalApplicationData), "Mecanic.db3"));
            }
            return database;
        }
    }

    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }
}