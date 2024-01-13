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
    static ClientDatabase clientDatabase;
    public static ClientDatabase ClientDatabase
    {
        get
        {
            if (clientDatabase == null)
            {
                clientDatabase = new
               ClientDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
               LocalApplicationData), "Client.db3"));
            }
            return clientDatabase;
        }
    }
    static ProgramareDatabase programareDatabase;
    public static ProgramareDatabase ProgramareDatabase
    {
        get
        {
            if (programareDatabase == null)
            {
                programareDatabase = new
               ProgramareDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
               LocalApplicationData), "Programare.db3"));
            }
            return programareDatabase;
        }
    }
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }
}