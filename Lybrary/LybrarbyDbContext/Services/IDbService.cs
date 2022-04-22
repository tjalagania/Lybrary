using Lybrary.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lybrary.LybrarbyDbContext.Services
{
    public interface IDbService<T>
    {
        public IAsyncEnumerable<T> GetAllLibraryan(Roole roole);
        public Task<T> GetDbObject(T dbobject);
        public Task<T> GetDboject(string username,string password);
        public void SetDbObject(T dbobject);
        public void DeleteDbObject(T dbobject);
        public void UpdateDbObject(T dbobject);

    }
}
