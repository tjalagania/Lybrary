using lybrarbyModels;
using Lybrary.common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lybrary.LybrarbyDbContext.Services
{
    public class UserManager : IDbService<Principal>
    {
        
        private readonly LibraryDbContextFactory factory;

        public UserManager(LibraryDbContextFactory _factory)
        {
            factory = _factory;
        }
        public void DeleteDbObject(Principal dbobject)
        {
            throw new NotImplementedException();
        }

        

        

        public async Task<Principal> GetDboject(string username, string password)
        {

            using LbDbContext context = factory.CreateDbContext();
            var tmppr = await context.Credentials.Include(p => p.User)
                  .SingleOrDefaultAsync(p => p.Username.Equals(username) && p.Password.Equals(password));
            context.Dispose();
            return ToPricipal(tmppr);

        }
        private static Principal ToPricipal(Credential cr)
        {
            Principal pr;
            if(cr!=null)
            {

            }
            switch (cr.IsAdmin)
            {
                case (int)Roole.Lybrarian:
                    pr = new Libraryan()
                    {
                        Name = cr.User.Name,
                        UserName = cr.Username,
                        Phone = cr.Phone,
                        Email = cr.Email,
                        Password = cr.Password,
                    };
                    break;
                case (int)Roole.Student:
                    pr = new Student()
                    {
                        Name = cr.User.Name,
                        UserName = cr.Username,
                        Phone = cr.Phone,
                        Email = cr.Email,
                        Password = cr.Password,
                    };
                    break;
                default:
                    throw new Exception("Can't find user");
            }
            return pr;
        }
        public async void SetDbObject(Principal dbobject)
        {
            using(LbDbContext context = factory.CreateDbContext())
            {
                await context.Credentials.AddRangeAsync(GetUserAndCredetial(dbobject));
                await context.SaveChangesAsync();
            }
        }

        public void UpdateDbObject(Principal dbobject)
        {
            throw new NotImplementedException();
        }

        private Credential  GetUserAndCredetial(Principal pr)
        {
            User tmpUser = new User()
            {
                Name = pr.Name,
            };
            Credential tmpcr = new Credential()
            {
                User = tmpUser,
                Phone = pr.Phone,
                Password = pr.Password,
                Email = pr.Email,
                IsAdmin = (int)pr.IsAdmin,
                Username = pr.UserName
            };
            return tmpcr;
        }

        

        public Task<Principal> GetDbObject(Principal dbobject)
        {
            throw new NotImplementedException();
        }

        

        //public async IAsyncEnumerable<Principal> GetAllLibraryanAsync(Roole roole)
        //{
           
        //}

        public async IAsyncEnumerable<Principal> GetAllLibraryan(Roole roole)
        {
            
            using LbDbContext context = factory.CreateDbContext();
            var  result = await Task.Run(() => context.Credentials.Include(m => m.User).Where(m => m.IsAdmin == (int)roole)
                .Select(m => ToPricipal(m)));

            if (result != null)
                foreach (var p in result)
                    yield return p;
            
        }
    }
}
