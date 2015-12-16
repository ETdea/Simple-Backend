//Sortable();

function Sortable() {
    var sortableArray = [];

    $("[data-sortable]").each(function () {
        var value = $(this).data("sortable");

        //檢查元素是否已經存在
        if ($.inArray(value, sortableArray) !== -1) {
            return;
        }

        var updateFuntion = eval("(" + $(this).data("sortable-update") + ")")

        var selector = "[data-sortable='" + value + "']";
        $(selector).sortable({
            connectWith: selector,
            update: updateFuntion
        }).disableSelection();

        sortableArray.push(value);
    });
}

