$(document).ready(function () {
    $('[data-datetimepicker]').each(function () {
        dateTimePicker($(this))
    });
});

function dateTimePicker(e)
{
    e.datetimepicker();
}