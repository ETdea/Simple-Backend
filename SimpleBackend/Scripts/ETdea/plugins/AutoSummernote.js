$(document).ready(function () {
    summernote($("[data-summernote]"));
});

function summernote(e)
{
    e.summernote({
        onChange: function (contents, $editable) {
            e.text(contents);
        }
    });
}