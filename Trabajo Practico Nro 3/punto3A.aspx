<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="punto3A.aspx.cs" Inherits="tp_grupal_3.punto3A" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 196px;
        }
        .auto-style3 {
            width: 196px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">SELECCIONAR TEMA:</td>
                <td>
                    <asp:DropDownList ID="ddltema" runat="server" AutoPostBack="True">
                        <asp:ListItem Value="1">tema 1</asp:ListItem>
                        <asp:ListItem Value="2">tema 2</asp:ListItem>
                        <asp:ListItem Value="3">tema 3</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4"></td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:LinkButton ID="linkbtn" runat="server" OnClick="linkbtn_Click">ver libros</asp:LinkButton>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
