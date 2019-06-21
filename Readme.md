<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/T142225/Controllers/HomeController.cs)
* [MyModel.cs](./CS/T142225/Models/MyModel.cs)
* [Index.cshtml](./CS/T142225/Views/Home/Index.cshtml)
* [Index2.cshtml](./CS/T142225/Views/Home/Index2.cshtml)
* [PageControlPartial.cshtml](./CS/T142225/Views/Home/PageControlPartial.cshtml)
* [PartialView1.cshtml](./CS/T142225/Views/Home/PartialView1.cshtml)
* [PartialView2.cshtml](./CS/T142225/Views/Home/PartialView2.cshtml)
* [PartialView3.cshtml](./CS/T142225/Views/Home/PartialView3.cshtml)
<!-- default file list end -->
# PageControl - How to load content using different action methods for each tab 
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t142225)**
<!-- run online end -->


<p>Sometimes it's required to load different models and action method on a tab click. There are two ways to accomplish this task: <br />1)  Use the $.ajax function in the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxTabControlScriptsASPxClientTabControlBase_ActiveTabChangingtopic">ActiveTabChanging</a>  event handler to accomplish this task;<br />2)  Use our built-in mechanisms for this task. The <a href="https://documentation.devexpress.com/AspNet/DevExpressWebASPxTabControlScriptsASPxClientTabControlTabCancelEventArgs_reloadContentOnCallbacktopic.aspx">reloadContentOnCallback</a> property allows you to send a callback to the server to reload the content of the page being activated. However in this case, the PageControl instance will be reloaded as well. </p>

<br/>


