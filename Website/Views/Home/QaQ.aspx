<%@ Page Title="" Language="VB" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage(Of Website.Client)" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>QaQ</h2>

    <%using Html.BeginForm() %>

    <ul>
    <li>
    Have you recently received a County Court claim form or Sheriff Court citation, which you have not yet responded to? 
    <%= Html.YesNo("county_court_claim", Model.county_court_claim)%>
     
    </li>
    </ul>

    <input type="submit" value="submit" />

    <%End Using %>

</asp:Content>
