<%@ Page Title="" Language="VB" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage(Of Website.Client)" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Income
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Income</h2>

     <%using Html.BeginForm() %>

    <ul>
    <li>
    Your take home pay <%= Html.TextBoxFor(Function(m) m.take_home_pay)%>
    <%=Html.PayFrequencyDropDown("take_home_pay_frequency", Model.take_home_pay_frequency)%>
    </li>
    </ul>
    <input type="submit" value="submit" />

    <%End Using%>

</asp:Content>
