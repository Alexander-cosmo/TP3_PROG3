<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="punto3b.aspx.cs" Inherits="tp_grupal_3.punto3b" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            LISTADO DE LIBRO:<br />
            <asp:GridView ID="grdtema" runat="server">
            </asp:GridView>
            <br />
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">consultar otro tema</asp:LinkButton>
        </div>
    </form>
</body>
</html>
