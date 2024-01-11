using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Vint_Anca_Service_Auto_V2.Models;


namespace Vint_Anca_Service_Auto_V2.Data
{
    public class MecanicDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public MecanicDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Mecanic>().Wait();
        }
        public Task<List<Mecanic>> GetMecaniciAsync()
        {
            return _database.Table<Mecanic>().ToListAsync();
        }
        public Task<Mecanic> GetMecanicAsync(int id)
        {
            return _database.Table<Mecanic>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SaveMecanicAsync(Mecanic mecanic)
        {
            if (mecanic.ID != 0)
            {
                return _database.UpdateAsync(mecanic);


            }

            else
            {
                return _database.InsertAsync(mecanic);
            }
        }
        public Task<int> DeleteMecanicAsync(Mecanic mecanic)
        {
            return _database.DeleteAsync(mecanic);
        }
    }
}