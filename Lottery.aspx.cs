﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Random r = new Random();
        int[] numbers = new int[49];
        for (int i = 1; i <= numbers.Length; i++)
        {
            numbers[i - 1] = i;
        }

        // shuffles
        for (int i = numbers.Length-1; i >=1; i--)
        {
            int x = r.Next(i+1);
            int tmp = numbers[i];
            numbers[i] = numbers[x];
            numbers[x] = tmp;
        }

        for (int i = 0; i < 6; i++)
        {
            Response.Output.Write("{0} ", numbers[i]);
        }
    }
}