<%@ Page Language="C#" MasterPageFile="~/Citizen/Citizen.master" AutoEventWireup="true" CodeFile="Vote.aspx.cs" Inherits="Citizen_Vote" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style7
    {
        width: 100%;
        height: 266px;
    }
    .style8
    {
        height: 25px;
    }
    .style9
    {
        height: 25px;
        width: 139px;
    }
    .style10
    {
        width: 139px;
    }
    .style11
    {
        width: 139px;
        height: 24px;
    }
    .style12
    {
        height: 24px;
    }
    .style13
    {
        width: 139px;
        height: 75px;
    }
    .style14
    {
        height: 75px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style7">
    <tr>
        <td class="style11">
        </td>
        <td class="style12">
        </td>
    </tr>
    <tr>
        <td class="style9">
            VoterId<br />
        </td>
        <td class="style8">
            <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
        </td>
    </tr>
    <tr>
        <td class="style13">
            VoterName</td>
        <td class="style14">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Home.aspx">Home 
            Page?</asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td class="style10">
            </td>
        <td>
        </td>
    </tr>
    <tr>
        <td class="style10">
            Select Party</td>
        <td>
            <asp:DropDownList ID="DropDownList2" runat="server" Height="16px" 
                style="margin-left: 0px" Width="126px">
                <asp:ListItem>-Select One-</asp:ListItem>
                <asp:ListItem>Congress</asp:ListItem>
                <asp:ListItem>Tdp</asp:ListItem>
                <asp:ListItem>trs</asp:ListItem>
                <asp:ListItem>bjp</asp:ListItem>
                <asp:ListItem>prp</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="style10">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            &nbsp;</td>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Clear" />
        &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Label" Visible="False" 
                Font-Bold="True"></asp:Label>
        </td>
    </tr>
</table>
<p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; You are voted to&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp; Party</p>
<p>
</p>
<p>
</p>
</asp:Content>

