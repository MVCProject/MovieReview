using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieReview.Models;
using MovieReview;
using System.Data.SqlClient;
using System.Web.Security;
using System.Security.Claims;
using System.Threading;

namespace System.Web.Mvc
{
    public class AuthorizeUserAccessLevel : AuthorizeAttribute
    {
        public string UserRole { set; get; }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            MainDbContext DB = new MainDbContext();
            string CurrentUser = "";
            string CurrentUserRole = "User";
            var isAuthorized = base.AuthorizeCore(httpContext);
            if (!isAuthorized)
            {
                return false;
            }
            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {
                //Get the current claims principal
                var identity = (ClaimsPrincipal)Thread.CurrentPrincipal;

                // Get the claims values
                var Email = identity.Claims.Where(c => c.Type == ClaimTypes.Email).Select(c => c.Value).SingleOrDefault();
                CurrentUser = Email.ToString();

                GetUserRole_Result result = DB.GetUserRole(CurrentUser).First();
                CurrentUserRole = result.UserRole;
            }
            if (this.UserRole.Contains(CurrentUserRole))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}