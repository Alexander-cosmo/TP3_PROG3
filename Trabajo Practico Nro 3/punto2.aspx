<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="punto2.aspx.cs" Inherits="Trabajo_Practico_Nro_3.punto2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Id Producto:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlproducto" runat="server">
                <asp:ListItem>Igual a:</asp:ListItem>
                <asp:ListItem>Menor a:</asp:ListItem>
                <asp:ListItem>Mayor a:</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtProducto" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;<br />
            Id Categoria:
            <asp:DropDownList ID="ddlcategoria" runat="server" style="margin-left: 13px">
                <asp:ListItem>Igual a:</asp:ListItem>
                <asp:ListItem>Menor a:</asp:ListItem>
                <asp:ListItem>Mayor a:</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="txtcategoria" runat="server" style="margin-left: 24px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="btnfiltrar" runat="server" style="margin-left: 176px" Text="Filtrar" OnClick="btnfiltrar_Click" />
            <asp:Button ID="btnquitarfiltro" runat="server" style="margin-left: 49px" Text="Quitar Fltro" OnClick="btnquitarfiltro_Click" />
            <br />
            <br />
            <asp:GridView ID="gvtabla" runat="server" style="margin-left: 109px">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
