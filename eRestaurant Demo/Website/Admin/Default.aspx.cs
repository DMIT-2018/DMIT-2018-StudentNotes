using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Website;

public partial class Admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PopulateUserInfo();
            PopulateRoleInfo();
        }
    }

    private void PopulateUserInfo()
    {
        UserManager mgr = new UserManager();
        SiteUsers.DataSource = mgr.Users.ToList();
        SiteUsers.DataBind();
    }

    private void PopulateRoleInfo()
    {
        //RoleManager<IdentityRole> mgr = new RoleManager<IdentityRole>(;
        //SiteRoles.DataSource = mgr.Roles.ToList();
        //SiteRoles.DataBind();
    }
}