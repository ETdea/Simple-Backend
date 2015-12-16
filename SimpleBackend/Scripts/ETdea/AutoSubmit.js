$(document).ready(function () {
    $("body").on("click", "[data-submit]", function () {
        var formId = $(this).data("submit");

        if (formId) {
            var form = $("#" + formId);
        } else {
            var form = $("FORM").first();
        }

        if (isForm(form)) {
            form.submit();
        };
    });

    $("[data-auto]").each(function () {
        if (!isForm($(this))) {
            return;
        }

        try {
            var input = eval($(this).data("auto"));
        } catch (e) { }

        var auto = input;

        if (typeof (input) == "function") {
            auto = input.call();

            if (auto == undefined) {
                auto = true;
            }
        }

        if (auto) {
            $(this).submit()
        }
    });
});

function autoSubmit(element) {
    if (element) {
        if (element.target)
            element = $(element.target);
    } else {
        element = $(this);
    }

    var form = isForm(element) ?
        element :
                element.parents("FORM");

    form.submit();
}

function isForm(element) {
    return element && element.prop("tagName") == "FORM";
}