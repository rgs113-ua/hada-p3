<%@ Page Title="Products Management" Language="C#" MasterPageFile="Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="proWeb.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        /* Estilos CSS para el formulario */
        .form-container {
            width: 80%;
            margin: 0 auto;
        }
        .form-group {
            margin-bottom: 10px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-container">
        <h2>Products Management</h2>
        
        <div class="form-group">
            <asp:Label ID="lblCode" runat="server" Text="Code:"></asp:Label>
            <asp:TextBox ID="txtCode" runat="server"></asp:TextBox>
        </div>
        
        <div class="form-group">
            <asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </div>
        
        <div class="form-group">
            <asp:Label ID="lblAmount" runat="server" Text="Amount:"></asp:Label>
            <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
        </div>

        <div class="form-group">
            <asp:Label ID="lblCategory" runat="server" Text="Category:"></asp:Label>
            <asp:DropDownList ID="ddlCategory" runat="server">
                <asp:ListItem Text="Computing" Value="0"></asp:ListItem>
                <asp:ListItem Text="Telephony" Value="1"></asp:ListItem>
                <asp:ListItem Text="Gaming" Value="2"></asp:ListItem>
                <asp:ListItem Text="Home appliances" Value="3"></asp:ListItem>
            </asp:DropDownList>
        </div>
        
        <div class="form-group">
            <asp:Label ID="lblPrice" runat="server" Text="Price:"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        </div>
        
        <div class="form-group">
            <asp:Label ID="lblCreationDate" runat="server" Text="Creation Date:"></asp:Label>
            <asp:TextBox ID="txtCreationDate" runat="server"></asp:TextBox>
        </div>
        
        <div class="form-group">
            <asp:Button ID="btnRead" runat="server" Text="Read" OnClick="btnRead_Click" />
            <asp:Button ID="btnReadFirst" runat="server" Text="Read First" OnClick="btnReadFirst_Click" />
            <asp:Button ID="btnReadPrevious" runat="server" Text="Read Previous" OnClick="btnReadPrevious_Click" />
            <asp:Button ID="btnReadNext" runat="server" Text="Read Next" OnClick="btnReadNext_Click" />
            <asp:Button ID="btnCreate" runat="server" Text="Create" OnClick="btnCreate_Click" />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
        </div>

        <asp:Label ID="lblMessage" runat="server" Text="La operación fue exitosa."></asp:Label>
        
    </div>
</asp:Content>