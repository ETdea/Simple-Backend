//自動存取值到session
function autoSession() {
    $("input[data-session]").each(function () {
        var sessionName = $(this).attr("name") + location.pathname;

        $(this).change(function () {
            sessionStorage.setItem(sessionName, $(this).val());
        });

        if (Boolean($(this).data("session"))) {
            $(this).val(sessionStorage.getItem(sessionName));
        } else {
            sessionStorage.removeItem(sessionName);
        }
    });
}