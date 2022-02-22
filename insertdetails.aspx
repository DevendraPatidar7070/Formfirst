<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insertdetails.aspx.cs" Inherits="PecificSchoolOfLow.insertdetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col">
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" text="*"  ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
                </div>
                <div class="col">
           <asp:Label ID="Label2" runat="server" Text="mobile"></asp:Label><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" text="*"  ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
                </div>
                <div class="col">
           <asp:Label ID="Label3" runat="server" Text="email"></asp:Label><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" text="*"      ControlToValidate="TextBox3"></asp:RequiredFieldValidator> 
                    </div>
                <div class="col">
           <asp:Label ID="Label4" runat="server" Text="subject"></asp:Label><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" text="*"  ControlToValidate="TextBox4"></asp:RequiredFieldValidator> 
                </div>
                <div class="col">
            <asp:Label ID="Label5" runat="server" Text="message"></asp:Label><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" text="*"  ControlToValidate="TextBox5"></asp:RequiredFieldValidator>
            </div>
                <div class="col">

            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

               </div> 

            <div class="col">
                <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
            </div>


            </div>
        </div>
    </form>
</body>
</html>
