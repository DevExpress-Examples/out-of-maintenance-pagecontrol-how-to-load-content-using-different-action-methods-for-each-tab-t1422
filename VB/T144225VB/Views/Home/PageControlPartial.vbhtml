@Html.DevExpress().PageControl(Sub(settings)
                                   settings.Name = "PageControl"
                                   settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "PageControlPartial"}
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
