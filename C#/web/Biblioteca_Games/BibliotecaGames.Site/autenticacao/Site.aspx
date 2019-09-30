<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Site.aspx.cs" Inherits="BibliotecaGames.Site.autenticacao.Site" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
          
            <div>
            <div>Usuário:</div>
            <div><asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox></div>

            <div>Senha:</div>
            <div> <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox></div>

            <div><asp:Label ID="lblStatus" runat="server"></asp:Label></div>

            <div><asp:Button ID="bntLogin" runat="server" OnClick="bntLogin_Click" Text="Entrar" /></div>
            </div>
            
    </form>
</body>
</html>
