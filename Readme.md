# PageControl - How to load content using different action methods for each tab 


<p>Sometimes it's required to load different models and action method on a tab click. There are two ways to accomplish this task: <br />1)  Use the $.ajax function in the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxTabControlScriptsASPxClientTabControlBase_ActiveTabChangingtopic">ActiveTabChanging</a>  event handler to accomplish this task;<br />2)  Use our built-in mechanisms for this task. The <a href="https://documentation.devexpress.com/AspNet/DevExpressWebASPxTabControlScriptsASPxClientTabControlTabCancelEventArgs_reloadContentOnCallbacktopic.aspx">reloadContentOnCallback</a> property allows you to send a callback to the server to reload the content of the page being activated. However in this case, the PageControl instance will be reloaded as well. </p>

<br/>


