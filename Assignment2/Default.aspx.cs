using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string[,] calEvent = new string[5, 2];
    protected void Page_Load(object sender, EventArgs e)
    {
        calEvent[0, 0] = "My Bday";
        calEvent[0, 1] = "10/19/2017";
        calEvent[1, 0] = "Fringe Festival";
        calEvent[1, 1] = "8/25/2017";
        calEvent[2, 0] = "Disneyland Paris";
        calEvent[2, 1] = "9/6/2017";
        calEvent[3, 0] = "Kevin's Bday";
        calEvent[3, 1] = "11/25/2017";
        calEvent[4, 0] = "Bailey's Bday";
        calEvent[4, 1] = "3/19/2017";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        GetEvents();
    }

    private void GetEvents()
    {
        Label1.Text = "";
        if (Calendar1.SelectedDate > DateTime.MinValue)
        {
            string calendarDateTime = Calendar1.SelectedDate.ToShortDateString();
            for (int i = 0; i < calEvent.GetLength(0); i++)
            {
                if (calEvent[i, 1].Equals(calendarDateTime))
                {
                    Label1.Text += calEvent[i, 0] + "<br />";
                }
            }
        }
        if (Label1.Text.Length == 0)
        {
            Label1.Text = "No events found.";
        }
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        //GetEvents();
        // debug for array length
        //Label1.Text = "Total length: " + calEvent.Length + "<br />Dimension 0: " + calEvent.GetLength(0) + "<br />Dimension 1: " + calEvent.GetLength(1);
    }
}