using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm
{
    public class User
    {
        private static int userID;
        private static User user = null;

        public static User getInstance()
        {
            if (user == null)
            {
                user = new User();
            }

            return user;
        }

        public static int UserID
        {
            get
            {
                return userID;
            }

            set
            {
                userID = value;
            }
        }
    }
}
