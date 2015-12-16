$(document).ready(function () {
    $("body").on("submit", "[data-autofill]", function () {
        var form = $(this);
        var key = form.data("autofill");
        var elements = $("[data-autoFill='" + key + "']").clone();

        form.html(null);
        form.hide();
        form.html(elements);
    });
});