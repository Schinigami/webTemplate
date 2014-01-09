using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webTemplate.Web.Global.Auth
{
    public interface IAuthCookieProvider
    {
        HttpCookie GetCookie(string cookieName);

        void SetCookie(HttpCookie cookie);
    }
}