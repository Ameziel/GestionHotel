using Microsoft.EntityFrameworkCore;

namespace GestionHotel.Apis.administration
{
    public class UserAPPRepository
    {
        private readonly AppDbContext _context;
        public UserAPPRepository(AppDbContext dbContext)
        {
            _context = dbContext;
        }

        public void AddUser(UserAPP user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public UserAPP GetUserById(Guid id) { 
            return _context.Users.FirstOrDefault(x => x.Id == id);
        }

        public List<UserAPP> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public void DeleteUser(Guid id)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }
    }
}
