@Code
    ViewData("Title") = "PageControl - How to load content when an active tab is changed using different action methods"
End Code

<h2>How to load content when an active tab is changed using built-in mechanisms</h2>
<script>
    function OnActiveTabChanging(s, e) {
        var action = e.tab.name;
        e.reloadContentOnCallback = true;
    }
</script>
<div style="display:block">
@Html.ActionLink("Refer to loading content using $.ajax", "Index", "Home")
</div>
@Html.Partial("PageControlPartial")