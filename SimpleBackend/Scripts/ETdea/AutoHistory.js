$(document).ready(function () {
    $("[data-history]").each(function () {
        var value = $(this).attr('data-history') || -1

        //go back ( value 為返回次數)
        $(this).on("click", function (e) {
            window.history.go(value);
        });
    });
});
