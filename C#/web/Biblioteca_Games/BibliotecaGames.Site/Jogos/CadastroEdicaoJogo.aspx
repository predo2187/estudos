<%@ Page Title="" Language="C#" MasterPageFile="~/Jogos/SiteMasterPage.Master" AutoEventWireup="true" CodeBehind="CadastroEdicaoJogo.aspx.cs" Inherits="BibliotecaGames.Site.Jogos.CadastroEdicaoJogo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
        <div class="form-group">
            
    <label for="exampleInputEmail1">Título</label>

            <div class="col-md-2">
            <asp:TextBox runat="server" ID="txtTitulo" CssClass="form-control"></asp:TextBox>
            <!-- adiciona um * na caixa de texto se nada for  escrito nela--><asp:RequiredFieldValidator ID="rfvTitulo" runat="server" ControlToValidate="txtTitulo" ErrorMessage="É necessário preencher o campo Título!" Text="*">
            </asp:RequiredFieldValidator>
                </div>
                
  </div>
        <div class="form-group">
            <div class="col-md-2">
    <label for="exampleInputEmail1">Valor Pago</label>
        <asp:TextBox runat="server" ID="txtValorPago" CssClass="form-control" TextMode="Number"></asp:TextBox>
                </div>
            </div>
        <div class="form-group">
            <div class="col-md-2">
    <label for="exampleInputEmail1">Data de Compra</label>
        <asp:TextBox runat="server" ID="txtDataCompra" CssClass="form-control" TextMode="Date"></asp:TextBox>
                </div>
            </div>
        <br />
        <div class="form-group">
            <div class="col-md-2">
    <label for="exampleInputEmail1">Imagem</label>
        <asp:FileUpload ID="FileOploadImage" runat="server" CssClass="form-control" />
                </div>
            </div>
        <br />
        <div class="form-group">
            <div class="col-md-2">
    <label for="exampleInputEmail1">Gênero</label>
        <asp:DropDownList ID="ddlGenero" runat="server" DataValueField="id" DataTextField="nome" CssClass="form-control"></asp:DropDownList>
            <asp:RequiredFieldValidator ID="rfvgenero" runat="server" ControlToValidate="ddlGenero" ErrorMessage="É necessário selecionar um Gênero!" Text="*">
                </asp:RequiredFieldValidator>
                </div>
            </div>
        <br />
        <div class="form-group">
            <div class="col-md-2">
    <label for="exampleInputEmail1">Editora</label>
        <asp:DropDownList ID="ddlEditora" runat="server" DataValueField="id" DataTextField="nome" CssClass="form-control"></asp:DropDownList>
            <asp:RequiredFieldValidator ID="rfvEditora" runat="server" ControlToValidate="ddlEditora" ErrorMessage="É necessário selecionar uma Editora!" Text="*">
                </asp:RequiredFieldValidator>
                </div>
            </div>
        <br />
        <asp:Button ID="btnGravar" runat="server" Text="Gravar" OnClick="btnGravar_Click" />
        <asp:Button ID="btnDeletar" runat="server" OnClick="btnDeletar_Click" Text="Deletar" />
        <br />

        <asp:Label runat="server" ID="lblMensagem"></asp:Label><br />
        <a href="catalogo.aspx">Voltar ao catálogo de jogos</a>



        <!--faz parte da caixa de texto--><asp:ValidationSummary ID="valSum" DisplayMode="BulletList" EnableClientScript="true"  ForeColor="Red" HeaderText="Preecha os campo(os) indicados!" runat="server" />

    




</asp:Content>
