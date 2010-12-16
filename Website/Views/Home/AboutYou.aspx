<%@ Page Title="" Language="VB" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage(Of Website.Client)" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	AboutYou
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>AboutYou</h2>

    <%using Html.BeginForm() %>

    <ul>
    <li>
    Who is your CCCS Debt Remedy for? 
    <%= Html.DropDownListFor(Function(m) m.debt_remedy_for, New List(Of SelectListItem) From
                                    {New SelectListItem With {.Text = "Myself", .Value = Website.DebtRemedyFor.JustMe.ToString},
                                     New SelectListItem With {.Text = "My partner and I", .Value = Website.DebtRemedyFor.MyPartnerAndI.ToString}
                                    }, "Please select")%>
    </li>
    </ul>
    <input type="submit" value="submit" />

    <%End Using%>

</asp:Content>
