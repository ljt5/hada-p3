<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="usuWeb.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Página de usuarios</h1>
    <p>
        NIF:
        <asp:TextBox ID="nifTextBox" TextMode="SingleLine"
            Columns="30" runat="server" />
    </p>
    <p>
        Nombre:
        <asp:TextBox ID="nombreTextBox"
            TextMode="Password" Columns="30" runat="server" />
    </p>
    <p>
        Edad:
        <asp:TextBox ID="edadTextBox"
            TextMode="Password" Columns="30" runat="server" />
    </p>
    <p>
        <asp:Button id="BotonLeer" Text="Leer" runat="server"/>
        <asp:Button id="BotonLeerPrimero" Text="Leer Primero" runat="server"/>
        <asp:Button id="BotonLeerAnterior" Text="Leer Anterior" runat="server"/>
        <asp:Button id="BotonLeerSiguiente" Text="Leer Siguiente" runat="server"/>
        <asp:Button id="BotonCrear" Text="Crear" runat="server"/>
        <asp:Button id="BotonActualizar" Text="Actualizar" runat="server"/>
        <asp:Button id="BotonBorrar" Text="Borrar" runat="server"/>
    </p>
</asp:Content>
