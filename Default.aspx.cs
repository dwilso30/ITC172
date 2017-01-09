using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string[] tipPercent = { "ten percent", "fifteen percent", "twenty percent", "Other" };
            TipPercentsRadioButtonList.DataSource = tipPercent;
            TipPercentsRadioButtonList.DataBind();
        }
    }
    protected void SumbitButton_Click(object sender, EventArgs e)
    {
        GetInfo();
    }
    protected void GetInfo()
    {
        Tip tip = new Tip();
        tip.MealAmount = double.Parse(MealTextBox.Text);
        if (OtherTextBox.Text == "")
        {
            foreach (ListItem item in TipPercentsRadioButtonList.Items)
            {
             
                if (item.Selected)
                {
                    if (item.Text.Equals("ten percent"))
                    {
                        tip.TipPercent = .1;
                    }
                    else if (item.Text.Equals("fifteen percent"))
                    {
                        tip.TipPercent = .15;
                    }
                    else if (item.Text.Equals("twenty percent"))
                    {
                        tip.TipPercent = .2;
                    }

                }
            }
        }
        else
        {
            tip.TipPercent = double.Parse(OtherTextBox.Text);
        }
            ResultLabel.Text = tip.MealAmount.ToString() + "<br/>" +
                "Tip: " + tip.CalculateTip().ToString() + "<br/>" +
                "tax: " + tip.CalculateTax().ToString() + "<br/>" +
                "total: " + tip.CalculateTotal().ToString();

        }
    }


