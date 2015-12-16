$("[data-clone]").each(function () {
    var remove = $(this).find("[data-clone-remove]");
    remove.hide();

    var key = $(this).data("data-clone") || "CloneKey";
    var cloneIndex = $(this).data("clone-index");
    var selfClone = $(this).clone();

    window[key] = new function () {
        var element = selfClone;
        var index = cloneIndex;

        this.removeName = remove.data("clone-remove");

        this.setInputName = function (source) {
            var i = source.data("clone-index");

            source.find("input").each(function () {
                var name = $(this).attr("name").replace(/\[([^"]*)\]/, "[" + i + "]");
                $(this).attr("name", name);
            });
        }

        this.pop = function () {
            index += 1;
            element.attr("data-clone-index", index);

            return element.clone();
        }
    };
});

$("body").on("click", "[data-clone-add]", function () {
    var parent = $(this).parents("[data-clone]");
    var key = $(this).data("data-clone") || "CloneKey";
    $(this).hide();

    parent.find("[data-clone-remove]").each(function () {
        $(this).show();
    });

    window[key].setInputName(parent);
    parent.after(window[key].pop());
});

$("body").on("click", "[data-clone-Remove]", function () {
    var parent = $(this).parents("[data-clone-index]");
    var key = $(this).data("data-clone") || "CloneKey";
    var index = parent.data("clone-index");
    var name = window[key].removeName.replace(/\[([^"]*)\]/, "[" + index + "]");

    parent.hide();

    if (name) {
        parent.append('<input name="' + name + '" value="true">');
    }
});
