$(document).ready(function () {
    console.log("ready!");

    var itemsUrl = "https://localhost:7084/api/menu/admin/ao/learner/manager";

    $.ajax({
        url: itemsUrl,
        type: "GET",
        cache: false,
        success: function (items) {
            if (items != null && items.length > 0) {
                var mainItems = [];
                for (let i = 0; i < items.length; i++) {
                    if (items[i].parentId == 0) {
                        mainItems.push(items[i]);
                    }
                }
                if (mainItems.length > 0) {
                    for (let i = 0; i < mainItems.length; i++) {
                        var childItems = [];
                        for (let j = 0; j < items.length; j++) {
                            if (items[j].parentId == mainItems[i].id) {
                                childItems.push(items[j]);
                            }
                        }

                        if (childItems.length > 0) {
                            var id = 'dropDownParent' + mainItems[i].id;
                            var dropDownParent = "<li class='nav-item dropdown' id='" + id + "'></li>";
                            $("#navBarItems").append(dropDownParent);
                            var dropDownFirstItem = "<a class='nav-link dropdown-toggle text-white' href='#' role='button' data-bs-toggle='dropdown'>" + mainItems[i].title + "</a>";
                            $('#' + id).append(dropDownFirstItem);
                            var ulId = 'ul' + mainItems[i].id;
                            var ulElement = "<ul class='dropdown-menu' id='" + ulId + "'></ul> ";
                            $('#' + id).append(ulElement);
                            for (let j = 0; j < childItems.length; j++) {
                                var liItem = "<li><a class='dropdown-item' href='" + childItems[j].link + "'>" + childItems[j].title + "</a></li>";
                                $('#' + ulId).append(liItem);
                            }
                        }
                        else {
                            var navItem = "<li class='nav-item'><a class='nav-link text-white' href='" + mainItems[i].link + "'>" + mainItems[i].title + "</a></li>";
                            $("#navBarItems").append(navItem);
                        }
                    }
                }
            }
        },
        error: function (jqXHR, exception) {
            console.log(jqXHR);
        }
    });
});