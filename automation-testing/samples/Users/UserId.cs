using System;
using System.Collections.Generic;
using System.Text;

namespace samples.Users
{
    class UserId
    {
        private readonly int _id;

        public UserId(int id)
        {
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id));
            }

            _id = id;
        }

        public int ToInt()
        {
            return _id;
        }
    }
}
