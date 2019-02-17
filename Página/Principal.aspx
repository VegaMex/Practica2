<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Principal.aspx.cs" Inherits="Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Aquí hay fichas</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btn_Agregar" runat="server" OnClick="btn_Agregar_Click" Text="Agregar" />
            <br />
        <div>
            <asp:Button ID="btn_Eliminar" runat="server" OnClick="btn_Agregar_Click" Text="Eliminar" />
        </div>
        </div>
        <div>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
