<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<PoC.MegaNav.Web.Models.ApiResponse>" %>

<nav class="navbar navbar-expand-sm navbar-toggleable-sm navbar-dark bg-dark">
    <div class="container">
        <% Url.Action("Application name", "Index", "Home"); %>
        <button type="button" class="navbar-toggler" data-bs-toggle="collapse" data-bs-target=".navbar-collapse" title="Toggle navigation" aria-controls="navbarSupportedContent"
                aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse d-sm-inline-flex justify-content-between">
            <ul class="navbar-nav flex-grow-1">
                <% foreach (var item in Model.MenuItems)
                   {
                %>
                        <li><%= Html.ActionLink(item.Title, item.Link, "Home", new { area = "" }, new { @class = "nav-link" }) %></li>
                <%
                   }
                %>
            </ul>
        </div>
    </div>
</nav>

<div id="dvMessage"></div>

<script crossorigin src="https://cdnjs.cloudflare.com/ajax/libs/react/16.13.0/umd/react.development.js"></script>
<script crossorigin src="https://cdnjs.cloudflare.com/ajax/libs/react-dom/16.13.0/umd/react-dom.development.js"></script>

<script src="<%= Url.Content("~/Scripts/meganav.jsx") %>"></script>
