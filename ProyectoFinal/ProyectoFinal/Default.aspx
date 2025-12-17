<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProyectoFinal._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Buscador Perfil GitHub</h1>
            <p class="lead"></p>
        </section>

        <div class="row">
            <div style="height:1000px; width:1000px;">
                <asp:Label ID="lblMensaje" runat="server" ForeColor="Red" Font-Size="35px" />

                <asp:TextBox ID="txbUsuario" runat="server" Style="margin-left: 50px; margin-top: 24px;" Width="335px" Height="41px"></asp:TextBox>
                
                <asp:Button ID="btnBuscar" Text="Buscar" ToolTip="Dar click para buscar usuario" runat="server" OnClick="btnBuscar_Click" />

            </div>
        </div>
    </main>

</asp:Content>
