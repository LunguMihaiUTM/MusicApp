using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicApp.BusinessLogic.DBModel;
using MusicApp.Domain.Entities.User;

namespace MusicApp.BusinessLogic.Core
{
    public class UserApi
    {
        internal ULoginResp UserLoginAction(ULoginData data)
        {
            using (var userContext = new UserContext())
            {
                var result = userContext.Users.FirstOrDefault(u => u.Username == data.Credential && u.Password == data.Password);
                if (result == null)
                {
                    return new ULoginResp { Status = false };
                }
            }
            return new ULoginResp { Status = true };
        }
    }
}
