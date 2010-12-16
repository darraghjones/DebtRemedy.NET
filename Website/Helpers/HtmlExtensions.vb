Imports System.Runtime.CompilerServices

Public Module HtmlExtensions

    <Extension()>
    Public Function YesNo(Of T)(ByVal Html As HtmlHelper(Of T), ByVal name As String, ByVal value As Boolean?) As MvcHtmlString
        Dim markup = Html.RadioButton(name, True, If(value, False), New With {.id = name & "_yes"}).ToString
        markup &= "<label for=""" & name & "_yes"">Yes</label>"
        markup &= Html.RadioButton(name, False, Not If(value, True), New With {.id = name & "_no"}).ToString
        markup &= "<label for=""" & name & "_no"">No</label>"
        Return MvcHtmlString.Create(markup)
    End Function

    <Extension()>
    Public Function PayFrequencyDropDown(Of t)(ByVal html As HtmlHelper(Of t), ByVal name As String, ByVal value As PayFrequency?) As MvcHtmlString
        Return html.DropDownList(name, New List(Of SelectListItem) From {
                                       New SelectListItem With {.Text = "Weekly", .Value = PayFrequency.Weekly, .Selected = (value IsNot Nothing AndAlso value = PayFrequency.Weekly)},
                                       New SelectListItem With {.Text = "Fortnightly", .Value = PayFrequency.Fortnightly, .Selected = (value IsNot Nothing AndAlso value = PayFrequency.Fortnightly)},
                                        New SelectListItem With {.Text = "4-weekly", .Value = PayFrequency.FourWeekly, .Selected = (value IsNot Nothing AndAlso value = PayFrequency.FourWeekly)},
                                        New SelectListItem With {.Text = "Monthly", .Value = PayFrequency.Monthly, .Selected = (value Is Nothing OrElse value = PayFrequency.Monthly)},
                                        New SelectListItem With {.Text = "Quartly", .Value = PayFrequency.Quarterly, .Selected = (value IsNot Nothing AndAlso value = PayFrequency.Quarterly)},
                                        New SelectListItem With {.Text = "Annually", .Value = PayFrequency.Annually, .Selected = (value IsNot Nothing AndAlso value = PayFrequency.Annually)}})

    End Function


End Module
