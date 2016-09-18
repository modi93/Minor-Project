<%@ Page Language="C#" MasterPageFile="~/Citizen/Citizen.master" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style6
    {
        width: 100%;
    }
    .style7
    {
            width: 239px;
        }
        .style8
        {
            width: 441px;
        }
        .style9
        {
            width: 189px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label2" runat="server" style="font-family: Arial" 
        Text="Register"></asp:Label>
</h3>
<table class="style6">
    <tr>
        <td class="style7">
            UserType</td>
        <td class="style8">
            <asp:DropDownList ID="DropDownList6" runat="server">
                <asp:ListItem>-Select One-</asp:ListItem>
                <asp:ListItem>Voter</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td class="style9" rowspan="6">
            <asp:Image ID="Image3" runat="server" Height="118px" Width="158px" />
        </td>
    </tr>
    <tr>
        <td class="style7">
            Citizen Voter ID</td>
        <td class="style8">
            <asp:TextBox ID="TextBox8" runat="server" ReadOnly="True"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style7">
            Citizen Name</td>
        <td class="style8">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style7">
            Father Name</td>
        <td style="margin-left: 80px" class="style8">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style7">
            Noof Children</td>
        <td style="margin-left: 80px" class="style8">
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style7">
            Noof Adult</td>
        <td class="style8">
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style7">
            Phone</td>
        <td class="style8">
            <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
        </td>
        <td class="style9">
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </td>
    </tr>
    <tr>
        <td class="style7">
            Email</td>
        <td class="style8">
            <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
        </td>
        <td class="style9">
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Upload" runat="server" onclick="Upload_Click" Text="Upload" />
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style7">
            District</td>
        <td class="style8">
            <asp:DropDownList ID="DropDownList3" runat="server" Height="16px" Width="131px">
                <asp:ListItem>Ongole</asp:ListItem>
                <asp:ListItem>Guntur</asp:ListItem>
                <asp:ListItem>rangareddy</asp:ListItem>
                <asp:ListItem>Khambham</asp:ListItem>
                <asp:ListItem>Chitturu</asp:ListItem>
                <asp:ListItem>Kadapa</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td class="style9">
            <asp:Label ID="Label3" runat="server" Text="Label" Visible="False"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style7">
            Constitution</td>
        <td class="style8">
            <asp:DropDownList ID="DropDownList4" runat="server" Height="16px" Width="129px">
                <asp:ListItem>Marturu</asp:ListItem>
                <asp:ListItem>Addanki</asp:ListItem>
                <asp:ListItem>Naresarao pet</asp:ListItem>
                <asp:ListItem>Chilakaluri pet</asp:ListItem>
                <asp:ListItem>Sattenapalli</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td class="style9">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style7">
            City\Village</td>
        <td class="style8">
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </td>
        <td class="style9">
            <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="X-Large" 
                ForeColor="#0066FF" Text="Label" Visible="False"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style7">
            Pin</td>
        <td class="style8">
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        </td>
        <td class="style9">
            <asp:Label ID="Label4" runat="server" Text="Deactivate" Visible="False"></asp:Label>
                                </td>
    </tr>
    <tr>
        <td class="style7">
            ElectionId</td>
        <td class="style8">
            <asp:TextBox ID="TextBox7" runat="server" ontextchanged="TextBox7_TextChanged"></asp:TextBox>
        </td>
        <td class="style9">
            <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                                </td>
    </tr>
    <tr>
        <td class="style7">
            Rationcard Type</td>
        <td class="style8">
            <asp:DropDownList ID="DropDownList5" runat="server" Height="20px" Width="129px">
                <asp:ListItem>-Select one-</asp:ListItem>
                <asp:ListItem>White</asp:ListItem>
                <asp:ListItem>Red</asp:ListItem>
                <asp:ListItem>Pink</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td class="style9">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style7">
            Age</td>
        <td class="style8">
            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" 
                ControlToValidate="TextBox9" ErrorMessage="RangeValidator" MaximumValue="99" 
                MinimumValue="18"></asp:RangeValidator>
        </td>
        <td class="style9">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style7">
            UserName</td>
        <td class="style8">
            <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
        </td>
        <td class="style9">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style7">
            Password</td>
        <td class="style8">
            <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
        </td>
        <td class="style9">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style7">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Button ID="Button2" runat="server" Text="Clear" onclick="Button2_Click" />
            &nbsp;</td>
        <td class="style8">
            <asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click" />
        </td>
        <td class="style9">
            &nbsp;</td>
    </tr>
    </table>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
</asp:Content>

