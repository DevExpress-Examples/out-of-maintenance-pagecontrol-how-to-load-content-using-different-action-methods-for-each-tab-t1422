Imports T144225VB.MVCxGridViewDataBinding.Models

Namespace T144225VB
    Public Class HomeController
        Inherits System.Web.Mvc.Controller

        Public Function PageControlPartial() As ActionResult
            Return PartialView()
        End Function
        Public Function Index() As ActionResult
            Return View()
        End Function
        Public Function Index2() As ActionResult
            Return View()
        End Function
        Public Function TabPage1() As ActionResult
            Dim model = DateTime.Now
            Return PartialView("PartialView1", model)
        End Function
        <ValidateInput(False)> _
        Public Function TabPage2() As ActionResult
            Dim model = MyModel.GetModelList()
            Return PartialView("PartialView2", model)
        End Function
        Public Function TabPage3() As ActionResult
            Dim model = New MyModel(3)
            Return PartialView("PartialView3", model)
        End Function
        <ValidateInput(False)> _
        Public Function GridViewPartial() As ActionResult
            Dim model = MyModel.GetModelList()
            Return PartialView("PartialView2", model)
        End Function
    End Class
End Namespace
