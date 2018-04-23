@Imports T144225VB.MVCxGridViewDataBinding.Models
@ModelType MyModel
@Html.DevExpress().FormLayout(Sub(settings)
                                  settings.Name = "FormLayout1"
                                  Dim groupItem As MVCxFormLayoutGroup(Of MyModel) = settings.Items.AddGroupItem("Contact Info")
                                  groupItem.GroupBoxDecoration = GroupBoxDecoration.Default
                                  groupItem.SettingsItems.ShowCaption = DefaultBoolean.True
                                  groupItem.SettingsItemCaptions.Location = LayoutItemCaptionLocation.Left

                                  groupItem.SettingsItemHelpTexts.Position = HelpTextPosition.Auto

                                  groupItem.Items.Add(Function(m) m.ModelID, Sub(item)
                                                                                 item.HelpText = "Enter ID"
                                                                             End Sub)
                                  groupItem.Items.Add(Function(m) m.ModelName, Sub(item)
                                                                                   item.HelpText = "Enter Name"
                                                                               End Sub)
                                  groupItem.Items.Add(Function(m) m.ModelState, Sub(item)
                                                                                    item.HelpText = "Define State"
                                                                                End Sub)
                                  groupItem.Items.Add(Function(m) m.ModelDate, Sub(item)
                                                                                   item.HelpText = "Setup Date"
                                                                               End Sub)
                              End Sub).GetHtml()
