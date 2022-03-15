using System;
using System.Collections.Generic;
using System.Text;

namespace samples.Users
{
    class UserRepository
    {
        public User GetUserById(UserId userId)
        {
            return new User
            {
                Email = new UserEmail("user@email.com"),
                Id = userId
            };
        }

        public void Update(User user)
        {

        }

        public void Save()
        {
            // dbContext.SaveChanges();
        }
    }
}
