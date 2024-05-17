using MusicApp.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MusicApp.BusinessLogic.Interfaces
{
    public interface ISession
    {
        URegResp UserRegister(URegData data);
        ULoginResp UserLogin(ULoginData data);
        HttpCookie GenCookie(string loginCredential);
        UserMinimal GetUserByCookie(string apiCookieValue);
    }
}
