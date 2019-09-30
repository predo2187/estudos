<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BibliotecaGames.Site.autenticacao.Login" %>

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
        <div><asp:TextBox ID="txtUsuario" runat="server" Width="128px"></asp:TextBox></div>
        <br />
        <div>Senha:</div>
        <div><asp:TextBox ID="txtSenha" runat="server" TextMode="Password" Width="121px"></asp:TextBox></div>
        </div>
    </form>
</body>
</html>
