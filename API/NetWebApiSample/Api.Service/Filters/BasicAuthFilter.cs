using Api.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Api.Service.Filters
{
    public class BasicAuthFilter:AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.Authorization == null)
            {
                actionContext.Response = actionContext.Request.CreateErrorResponse(System.Net.HttpStatusCode.Unauthorized,"yetkisiz istek");
            }
            else
            {
                //Base64 tipinde şifreli => YTUHKASd86TYasd
                //admin
                //1234
                string authToken = actionContext.Request.Headers.Authorization.Parameter;
                string decodeAuthToken = Encoding.UTF8.GetString(Convert.FromBase64String(authToken));
                //admin:123
                string[] userNamePassArray = decodeAuthToken.Split(':');
                //0=> admin
                //1=> password
                string userName = userNamePassArray[0];
                string password = userNamePassArray[1];

                if (AppUserSecurity.Login(userName, password))
                {
                    Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(userName), null);
                }
                else
                {
                    actionContext.Response = actionContext.Request.CreateErrorResponse(System.Net.HttpStatusCode.Unauthorized, "yetkisiz istek");
                }

            }
        }
    }
}