﻿using SASSADirectCapture.Sassa;
using System;
using System.Web.UI;

namespace SASSADirectCapture.Views
{
    public partial class LocalOffice : SassaPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                ddlRegion.DataSource = util.getRegions();
                ddlRegion.DataBind();
            }
        }

        protected void ddlRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlRegion.SelectedValue != string.Empty)
            {
                ddlLocalOffice.DataSource = util.getLocalOffices(ddlRegion.SelectedValue);
                ddlLocalOffice.DataBind();
            }
            else
            {
                ddlLocalOffice.DataSource = null;
                ddlLocalOffice.DataBind();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
            divError.Visible = false;

            if (ddlLocalOffice.SelectedValue != string.Empty)
            {
                try
                {
                    //Update database with new local office for user.//428
                    util.updateUserLocalOffice(UserSession.SamName, ddlLocalOffice.SelectedValue);
                    //Clear local office session so that it is refreshed from master page.
                    util.clearLocalOfficeSession();

                    ScriptManager.RegisterStartupScript(this, GetType(), "closeFancyBox", "parent.jQuery.fancybox.close();", true);
                }
                catch (Exception ex)
                {
                    //lblError.Text = ex.Message;
                    lblError.Text = ex.ToString();
                    divError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "No local office selected.";
                divError.Visible = true;
            }
            UserSession.IsIntitialized = false;
            Session["us"] = UserSession;
        }
    }
}