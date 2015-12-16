$(document).ready(function () {
    autoTest();
    //$("table[data-datatable]").each(function (){
    //    $(this).data("datatable", myDataTable($(this)));
    //});    
});

function autoTest() {
    $("table[data-datatable]").each(function () {
        $(this).data("datatable", myDataTable($(this)));
    });
}

function myDataTable(table) {
    var lengthChange = typeof (table.data("lengthchange")) === "string" ? table.data("lengthchange") : true;
    var domFilteringInput = table.data("searching") === "hide" ? "" : "f";
    var domButtons = "";
    var buttons = null;

    if (table.data("excelhtml5").toLowerCase() !== "false") {
        domButtons = "B";
        buttons = [
            {
                extend: 'excelHtml5',
                footer: true
            }
        ];
    }
    
    var data = table.DataTable({
        "lengthChange": lengthChange,
        dom: domFilteringInput + domButtons,
        buttons: buttons
            
    });
    
    table.find("[data-search]").each(function () {
        var inputId = $(this).data("search");

        var that = data.columns($(this).index());

        $("#" + inputId).on('keyup change', function () {
            if (that.search() !== this.value) {
                that.search(this.value)
                    .draw();
            }
        });

        $("#" + inputId).keyup();
    });

    return data;
}

function RemoveChecked() {
    $("[data-removecheck]:checked").parents("table").data("datatable").rows($("[data-removecheck]:checked").parents("tr")).remove().draw();
}