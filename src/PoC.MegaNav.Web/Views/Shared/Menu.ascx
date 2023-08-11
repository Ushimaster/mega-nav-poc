<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<PoC.MegaNav.Web.Models.MenuItem>" %>

<%@ Import Namespace="System.Collections.Generic" %>
<%@ Import Namespace="System.Web.Mvc" %>
<%@ Import Namespace="PoC.MegaNav.Web.Models" %>

<nav class="navbar navbar-expand-sm navbar-toggleable-sm navbar-dark bg-dark">
    <div class="container">
        <%--<% Url.Action("Application name", "Index", "Home", new { area = "" }, new { @class = "navbar-brand" }); %>--%>
        <button type="button" class="navbar-toggler" data-bs-toggle="collapse" data-bs-target=".navbar-collapse" title="Toggle navigation" aria-controls="navbarSupportedContent"
                aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse d-sm-inline-flex justify-content-between">
            <ul class="navbar-nav flex-grow-1">
                <%--<% foreach (var item in Model)
                   {
                %>
                        <li><a href="<%: Url.Action(item.Title, item.Link) %> class="nav-link" /></li>
                <%
                   }
                %>--%>
            </ul>
        </div>
    </div>
</nav>
