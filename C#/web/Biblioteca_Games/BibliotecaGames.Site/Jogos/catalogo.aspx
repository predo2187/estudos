<%@ Page Title="" Language="C#" MasterPageFile="~/Jogos/SiteMasterPage.Master" AutoEventWireup="true" CodeBehind="catalogo.aspx.cs" Inherits="BibliotecaGames.Site.Jogos.catalogo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Content/Jogos/catalogo.css" rel="stylesheet" />
    <h2>Catálogo de Jogos</h2>
    <a href="CadastroEdicaoJogo.aspx">cadastrar novo Jogo</a>
    <hr />
    <asp:Repeater ID="RepeaterJogos" runat="server">
        <ItemTemplate>
            <div class="jogo" onclick="RedirecionarParaAPaginaDoJogo('<%=Session["Perfil"].ToString()%>',<%# DataBinder.Eval(Container.DataItem, "id")%>)">
                <div class="capaJogo">
                    <img src="../Content/ImagensJogos/<%# DataBinder.Eval(Container.DataItem, "imagem") %>" alt="<%# DataBinder.Eval(Container.DataItem, "Titulo") %>"></img>
                </div>   
                <div class="nomeJogo">
                    <%# DataBinder.Eval(Container.DataItem, "Titulo") %>
                </div>
            </div>

        </ItemTemplate>
    </asp:Repeater>

    <!--Aqui já é um código mesmo, pode ser PHP, Java, ou c# como está abaixo--><script>
                function RedirecionarParaAPaginaDoJogo(perfil, id) {
                    if (perfil === 'A') {
                        top.location.href = "/Jogos/CadastroEdicaoJogo.aspx?id=" + id;

                    } else {
                        top.location.href = "/Jogos/DetalhesJogo.aspx?id=" + id;
                    }
                }
            </script>

</asp:Content>
