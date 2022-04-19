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

        public Task<Principal> GetAll()
        {
            throw new NotImplementedException();
        }

        

        public async Task<Principal> GetDboject(string username, string password)
        {
            Credential tmppr;
            using (LbDbContext context = factory.CreateDbContext())
            {
                tmppr = await context.Credentials.Include(p => p.User)
                    .SingleOrDefaultAsync(p => p.Username.Equals(username) && p.Password.Equals(password));
                    
                
            }
            return ToPricipal(tmppr)??null;
        }
        private Principal ToPricipal(Credential cr)
        {
            Principal pr;
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

        Task<IEnumerable<Principal>> IDbService<Principal>.GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Principal> GetDbObject(Principal dbobject)
        {
            throw new NotImplementedException();
        }
    }
}
