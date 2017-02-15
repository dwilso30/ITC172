<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
<tr>
    <td>LastName</td>
    <td>
        <asp:TextBox ID="LastNameTextBox" runat="server"></asp:TextBox></td>
    <td>
        <asp:RequiredFieldValidator ID="LastNameValidator" runat="server" ErrorMessage="Last name is required" ControlToValidate="LastNameTextBox"></asp:RequiredFieldValidator>
    </td>
</tr>
<tr>
    <td>FirstName</td>
    <td>
        <asp:TextBox ID="FirstNameTextBox" runat="server"></asp:TextBox></td>
    <td></td>
</tr>
<tr>
    <td>Email</td>
    <td>
        <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox></td>
    <td>
        <asp:RequiredFieldValidator ID="EmailValidator" runat="server" ErrorMessage="Email is required" ControlToValidate="EmailTextBox"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="EmailRegularExpressionValidator" runat="server" ErrorMessage="invalid email" ControlToValidate="EmailTextBox" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
    </td>
</tr>
<tr>
    <td>Apartment Number</td>
    <td>
        <asp:TextBox ID="ApartmentTextBox" runat="server"></asp:TextBox></td>
    <td></td>
</tr>
<tr>
    <td>Street</td>
    <td>
        <asp:TextBox ID="StreetTextBox" runat="server"></asp:TextBox></td>
    <td></td>
    </tr>
    <tr>
    <td>City</td>
    <td>
        <asp:TextBox ID="CityTextBox" runat="server"></asp:TextBox></td>
    <td></td>
</tr>
    <tr>
    <td>State</td>
    <td>
        <asp:TextBox ID="StateTextBox" runat="server"></asp:TextBox></td>
        <td></td>
</tr>
<tr>
    <td>Zipcode</td>
    <td>
        <asp:TextBox ID="ZipcodeTextBox" runat="server"></asp:TextBox></td>
    <td></td>
</tr>
<tr>
    <td>Home Phone</td>
    <td>
        <asp:TextBox ID="HomeTextBox" runat="server"></asp:TextBox></td>
    <td></td>
</tr>
<tr>
    <td>Work Phone</td>
    <td>
        <asp:TextBox ID="WorkTextBox" runat="server"></asp:TextBox></td>
    <td></td>
</tr>
            <tr>
                <td>Password</td>
                <td>
                    <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>Confirm Password</td>
                <td>
                    <asp:TextBox ID="ConfirmTextBox" runat="server" TextMode="Password"></asp:TextBox></td>
           <td> 
               <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Passwords Don't Match" ControlToValidate="ConfirmTextBox" ControlToCompare="PasswordTextBox"></asp:CompareValidator>
           </td>
                 </tr>
            <tr>
                <td>
                    <asp:Button ID="SumbitButton" runat="server" Text="Submit" OnClick="SumbitButton_Click" /></td>
                <td>
                    <asp:Label ID="ResultLabel" runat="server" Text="Label"></asp:Label></td>
            </tr>

        </table>
    
    </div>
    </form>
</body>
</html>
