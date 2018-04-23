@Code
    Dim grid = Html.DevExpress().GridView(Sub(settings)
    
        settings.Name = "GridView"
        settings.CallbackRouteValues = New With { .Controller = "Home", .Action = "GridViewPartial" }


        settings.KeyFieldName = "ModelID"

        settings.SettingsPager.Visible = true
        settings.Settings.ShowGroupPanel = true
        settings.Settings.ShowFilterRow = true
        settings.SettingsBehavior.AllowSelectByRowClick = true

        settings.Columns.Add("ModelID")
        settings.Columns.Add("ModelName")
        settings.Columns.Add("ModelState")
        settings.Columns.Add("ModelDate")
    End Sub)
End Code
@grid.Bind(Model).GetHtml()

