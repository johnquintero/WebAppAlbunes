<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAppAlbunesJJQP._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Aplicación Albunes</h1>
        <p class="lead">Prueba Bertoni</p>
        
    </div>
     
<asp:UpdatePanel ID="UpdatePanel1" runat="server" ClientIDMode="Static"> 
    <ContentTemplate>
    <div class="row">
        <div class="col-md-12">
            <h2>Seleccione el Album a consultar</h2>
            <asp:DropDownList ID="ddlalbunes" runat="server" DataTextField="title" DataValueField="id" CssClass="custom-select"></asp:DropDownList>
            <asp:Button ID="btnConsultar" runat="server" Text="consultar" OnClick="btnConsultar_Click" CssClass="btn btn-primary" />
        </div>
        <br />
        <br />
       <div  style="width: 100%; height: 400px; overflow: scroll">
           <asp:GridView ID="gvwFotos" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvwFotos_SelectedIndexChanged">
               <Columns>
                   <asp:BoundField DataField="id" HeaderText="Id" />
                   <asp:BoundField DataField="title" HeaderText="Nombre" />
                   <asp:ImageField DataImageUrlField="url" HeaderText="foto">
                       <ItemStyle Height="100px" Width="100px" />
                   </asp:ImageField>
                   <asp:CommandField SelectText="Ver Comentarios" ShowSelectButton="True" />
               </Columns>
           </asp:GridView>
       </div>
        <hr />
        <h3>Comentarios</h3>
       <div>
           <asp:GridView ID="gvwcomentarios" runat="server"></asp:GridView>
       </div>
    </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
