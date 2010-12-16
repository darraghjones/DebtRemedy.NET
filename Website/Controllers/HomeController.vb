
Public Class HomeController
    Inherits System.Web.Mvc.Controller


    <HttpGet()>
    Function QaQ() As ActionResult
        Return View(SessionHelper.Client)
    End Function

    <HttpPost()>
    Function QaQ(ByVal client As Client) As ActionResult

        If ModelState.IsValid Then
            SessionHelper.Client = client
            Return RedirectToAction("AboutYou")
        End If
        Return View(client)
    End Function

    <HttpGet()>
    Function AboutYou() As ActionResult
        Return View(SessionHelper.Client)
    End Function

    <HttpPost()>
    Function AboutYou(ByVal client As Client) As ActionResult

        If ModelState.IsValid Then
            SessionHelper.Client = client
            Return RedirectToAction("AboutYou")
        End If
        Return View(client)
    End Function

    <HttpGet()>
    Function Income() As ActionResult
        Return View(SessionHelper.Client)
    End Function

    <HttpPost()>
    Function Income(ByVal client As Client) As ActionResult

        If ModelState.IsValid Then
            SessionHelper.Client = client
            Return RedirectToAction("Income")
        End If
        Return View(client)
    End Function

End Class

Public Class SessionHelper

    Public Shared Property Client As Client
        Get
            If HttpContext.Current.Session("client") Is Nothing Then HttpContext.Current.Session("client") = New Client
            Return CType(HttpContext.Current.Session("client"), Client)
        End Get
        Set(ByVal value As Client)
            HttpContext.Current.Session("client") = value
        End Set
    End Property


End Class
