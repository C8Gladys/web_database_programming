﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AjaxTest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void Timer1_Tick(object sender, EventArgs e)
    {
        Literal1.Text = DateTime.Now.ToString();
    }
}