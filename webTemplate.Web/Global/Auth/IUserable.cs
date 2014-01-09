using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using webTemplate.Model;

namespace webTemplate.Web.Global.Auth
{
    public interface IUserable : IIdentity
    {
        User User { get; }
    }
}