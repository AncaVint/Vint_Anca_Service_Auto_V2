using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Vint_Anca_Service_Auto_V2.Models;


namespace Vint_Anca_Service_Auto_V2.Data
{
    public class ClientDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public ClientDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Client>().Wait();
        }
        public Task<List<Client>> GetClientiAsync()
        {
            return _database.Table<Client>().ToListAsync();
        }
        public Task<Client> GetClientAsync(int id)
        {
            return _database.Table<Client>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SaveClientAsync(Client client)
        {
            if (client.ID != 0)
            {
                return _database.UpdateAsync(client);


            }

            else
            {
                return _database.InsertAsync(client);
            }
        }
        public Task<int> DeleteClientAsync(Client client)
        {
            return _database.DeleteAsync(client);
        }
    }
}