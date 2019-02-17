<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Agregar.aspx.cs" Inherits="Frontend.Agregar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Nueva ficha</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Registro de fichas</h2>
        </div>
        <hr />
        <div>
            Nombre del alumno:<br />
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br /><br />
            Apellido paterno:<br />
            <asp:TextBox ID="txtPaterno" runat="server"></asp:TextBox>
            <br /><br />
            Apellido materno:<br />
            <asp:TextBox ID="txtMaterno" runat="server"></asp:TextBox>
            <br /><br />
            Número de ficha:<br />
            <asp:TextBox ID="txtFicha" runat="server"></asp:TextBox>
            <br /><br />
            Fecha de solicitud:<br />
            <asp:Calendar ID="dateCalendario" runat="server"></asp:Calendar>
            <br />
            Escuela de procedencia:<br />
            <asp:TextBox ID="txtProcedencia" runat="server"></asp:TextBox>
            <br /><br />
            Opción 1 de carrera:<br />
            <asp:DropDownList ID="cboOpcion1" runat="server">
                <asp:ListItem>Sistemas Computacionales</asp:ListItem>
                <asp:ListItem>Sistemas Automotrices</asp:ListItem>
                <asp:ListItem>Gestión Empresarial</asp:ListItem>
                <asp:ListItem>Industrial</asp:ListItem>
                <asp:ListItem>Electrónica</asp:ListItem>
                <asp:ListItem>Gastronomía</asp:ListItem>
            </asp:DropDownList>
            <br /><br />
            Opción 2 de carrera:<br />
            <asp:DropDownList ID="cboOpcion2" runat="server">
                <asp:ListItem>Ninguna</asp:ListItem>
            <asp:ListItem>Sistemas Computacionales</asp:ListItem>
                <asp:ListItem>Sistemas Automotrices</asp:ListItem>
                <asp:ListItem>Gestión Empresarial</asp:ListItem>
                <asp:ListItem>Industrial</asp:ListItem>
                <asp:ListItem>Electrónica</asp:ListItem>
                <asp:ListItem>Gastronomía</asp:ListItem>            
            </asp:DropDownList>
            <br /><br />
            Opción 3 de carrera:<br />
            <asp:DropDownList ID="cboOpcion3" runat="server">
                <asp:ListItem>Ninguna</asp:ListItem>
                <asp:ListItem>Sistemas Computacionales</asp:ListItem>
                <asp:ListItem>Sistemas Automotrices</asp:ListItem>
                <asp:ListItem>Gestión Empresarial</asp:ListItem>
                <asp:ListItem>Industrial</asp:ListItem>
                <asp:ListItem>Electrónica</asp:ListItem>
                <asp:ListItem>Gastronomía</asp:ListItem>
            </asp:DropDownList>
            <br /><br />
            Promedio:<br />
            <asp:TextBox ID="txtPromedio" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />

        </div>
    </form>
</body>
</html>
