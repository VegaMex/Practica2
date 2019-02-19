<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Página Principal.aspx.cs" Inherits="Frontend.Página_Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Página Principal</title>
    <link rel="stylesheet" href="StyleSheet.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Fichas</h2>
        </div>
        <div>
            <asp:Button ID="btn_Agregar" runat="server" OnClick="btn_Agregar_Click" Text="Agregar" CssClass="boton" />
            <br />
            <br />
            Ingrese ID:<br />
            <asp:TextBox ID="txtID" runat="server" Width="70px" CssClass="campo"></asp:TextBox>
            <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" CssClass="boton"/>
            <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click" CssClass="boton"/>
            <br />
            <br />
        </div>
        <div>
            <asp:GridView ID="grdTabla" runat="server" CssClass="tabla">
                <RowStyle HorizontalAlign="Center" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
