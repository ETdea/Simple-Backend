$(document).ready(function () {
    $("input[data-localStorage]").each(function () {
        var name = $(this).attr("name");

        $(this).change(function () {
            localStorage.setItem(name, $(this).val());
        });

        if ($(this).val())
        {
            localStorage.setItem(name, $(this).val());
        } else {
            $(this).val(localStorage.getItem(name));
        }
    });
});