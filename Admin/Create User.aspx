<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="Create User.aspx.cs" Inherits="Admin_Create_User" Title="Untitled Page" %>

<script runat="server">

   
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
             
            onrowcommand="GridView1_RowCommand" 
            onselectedindexchanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField HeaderText="VoterId" DataField ="VoterId" />
                <asp:BoundField HeaderText="VoterName" DataField ="VoterName"/>
                <asp:BoundField HeaderText="Utype" DataField ="Utype" />
                <asp:TemplateField HeaderText="Status" >
                <ItemTemplate>
                    <asp:LinkButton ID="Status" runat="server" Text='<%#Eval("Status") %>' CommandArgument ='<%#Eval("VoterId") %>' ></asp:LinkButton>
                </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField HeaderText="Email" DataField="Email"/>
            </Columns>
        </asp:GridView>
    </p>
    <p>
    </p>
</asp:Content>

