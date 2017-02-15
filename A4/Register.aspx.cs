using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SumbitButton_Click(object sender, EventArgs e)
    {
        SubmitRegistration();
    }

    protected void SubmitRegistration()
    {
        string lastname = LastNameTextBox.Text;
        string fristname = FirstNameTextBox.Text;
        string email = EmailTextBox.Text;
        string apratment = ApartmentTextBox.Text;
        string street = StreetTextBox.Text;
        string city = CityTextBox.Text;
        string state = StateTextBox.Text;
        string zip = ZipcodeTextBox.Text;
        string home = HomeTextBox.Text;
        string work = WorkTextBox.Text;
        string password = PasswordTextBox.Text;

        Community_AssistEntities cae = new Community_AssistEntities();
        int result = cae.usp_Register(lastname, FirstNameTextBox, email, password, apartment, street, city, state, zip, home, work);

        if (result != -1)
            Response.Redirect("Default.aspx");
        else
            ResultLabel.Text = "something went really wrong";
    }
}