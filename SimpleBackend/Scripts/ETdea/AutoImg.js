
$("body").bind("DOMSubtreeModified", ImgOnError);

function ImgOnError() {
    $("img[data-default]").error(function () {
        var src = $(this).data("default");

        this.src = src;
        return true;
    });
}