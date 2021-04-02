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
            TextMode="SingleLine" Columns="30" runat="server" />
    </p>
    <p>
        Edad:
        <asp:TextBox ID="edadTextBox"
            TextMode="SingleLine" Columns="30" runat="server" />
    </p>
    <p>
        <asp:Button id="BotonLeer" Text="Leer" runat="server" OnClick="Read"/>
        <asp:Button id="BotonLeerPrimero" Text="Leer Primero" runat="server" OnClick="ReadFirst"/>
        <asp:Button id="BotonLeerAnterior" Text="Leer Anterior" runat="server" OnClick="ReadPrevious"/>
        <asp:Button id="BotonLeerSiguiente" Text="Leer Siguiente" runat="server" OnClick="ReadNext"/>
        <asp:Button id="BotonCrear" Text="Crear" runat="server" OnClick="Create"/>
        <asp:Button id="BotonActualizar" Text="Actualizar" runat="server" OnClick="Update"/>
        <asp:Button id="BotonBorrar" Text="Borrar" runat="server" OnClick="Delete"/>
    </p>
    <p>
        <asp:Label id="Label1" runat="server" />
    </p>
</asp:Content>
