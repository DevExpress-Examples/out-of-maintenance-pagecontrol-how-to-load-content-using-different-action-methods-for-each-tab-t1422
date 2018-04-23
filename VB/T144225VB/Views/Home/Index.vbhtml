@Code
    ViewBag.Title = "PageControl - How to load content when an active tab is changed using different action methods"
End Code

<h2>How to load content when an active tab is changed using different action methods</h2>
<script>
    function OnActiveTabChanging(s, e) {
        var action = e.tab.name;
        var actionUrl = window.location + "/Home/" + action;
        $.ajax({
            type: "POST",
            url: actionUrl,
            success: function (response) {
                $("#" + action).html(response);
            }
        });
    }
</script>
<div style="display:block">
@Html.ActionLink("Refer to loading content using built-in mechanisms", "Index2", "Home")
    </div>
@Html.DevExpress().PageControl(Sub(settings)

    settings.Name = "PageControl"
    settings.TabPages.Add(Sub(tabpage)
    
        tabpage.Name = "TabPage1"
        tabpage.Text = "Page 1"
        tabpage.SetContent(Sub() 
        
            ViewContext.Writer.Write(String.Format("<div id='{0}' >", tabpage.Name))
            Html.RenderAction(tabpage.Name)
            ViewContext.Writer.Write("</div>")
        End Sub)
    End Sub)
    settings.TabPages.Add(Sub(tabpage)
    
        tabpage.Name = "TabPage2"
        tabpage.Text = "Page 2"
        tabpage.SetContent(Sub()
      
            ViewContext.Writer.Write(String.Format("<div id='{0}' >", tabpage.Name))
            Html.RenderAction(tabpage.Name)
            ViewContext.Writer.Write("</div>")
        End Sub)
    End Sub)
    settings.TabPages.Add(Sub(tabpage)
    
        tabpage.Name = "TabPage3"
        tabpage.Text = "Page 3"
        tabpage.SetContent(Sub() 
        
            ViewContext.Writer.Write(String.Format("<div id='{0}'>", tabpage.Name))
            Html.RenderAction(tabpage.Name)
            ViewContext.Writer.Write("</div>")
        End Sub)
    End Sub)
    settings.ClientSideEvents.ActiveTabChanging = "OnActiveTabChanging"
End Sub).GetHtml()
