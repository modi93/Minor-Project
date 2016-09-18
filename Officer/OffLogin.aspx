<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OffLogin.aspx.cs" Inherits="Officer_OffLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <table style="width: 340px; position: static; height: 196px" align="center">
            <tr>
                <td colspan="3" class="style1">
                    &nbsp;<asp:Label ID="Label8" runat="server" Font-Bold="True" 
                        Style="position: static" Text="Officer Login &gt;&gt;"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 100px; height: 21px" class="style1">
                    <asp:Label ID="Label7" runat="server" Style="position: static" 
                        Text="User Name :"></asp:Label>
                </td>
                <td style="width: 100px; height: 21px" class="style1">
                    <asp:TextBox ID="TextBox4" runat="server" Style="position: static"></asp:TextBox>
                </td>
                <td style="width: 100px; height: 21px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                    <asp:Label ID="Label6" runat="server" Font-Bold="False" 
                        Style="position: static" Text="Password :"></asp:Label>
                </td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox5" runat="server" Style="position: static" 
                        TextMode="Password"></asp:TextBox>
                </td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td align="center" colspan="3">
                    <asp:Label ID="Label1" runat="server" Style="position: static"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 100px; height: 26px;" class="style1">
                </td>
                <td style="width: 100px; height: 26px;">
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" 
                        Style="position: static" Text="Sign In &gt;&gt;" />
                </td>
                <td style="width: 100px; height: 26px;">
                    <asp:Button ID="Button4" runat="server" onclick="Button4_Click" Text="Clear" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
