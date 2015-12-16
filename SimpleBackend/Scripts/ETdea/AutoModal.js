$(document).ready(function () {
    $("body").on("click", "[data-modal]", function () {
        var modalId = $(this).data("modal") || "modal";

        $("#" + modalId).modal('show');
    });
});