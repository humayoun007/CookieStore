using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookieStore.Models
{
    public class Repository : IRepository
    {
        private readonly DatabaseContext _dbContext;
        public Repository(DatabaseContext databaseContext)
        {
            _dbContext = databaseContext;

        }
        public IEnumerable<Cookie> GetAllCookies()
        {
            return _dbContext.Cookies;
        }

        public Cookie GetCookieById(int id)
        {
            return _dbContext.Cookies.FirstOrDefault(x => x.Id == id);
        }
    }
}
