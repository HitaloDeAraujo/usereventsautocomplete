$(function () {

    function log(message) {
        $("<div>").text(message).prependTo("#log");
        $("#log").scrollTop(0);
    }

    $("#evento").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "http://localhost:65462/api/AutoComplete",
                dataType: "json",
                data: {
                    entrada: request.term
                },
                success: function (data) {
                    response(data);
                },
                error: function (data, err) {
                    alert(data.responseText);
                    console.log(err);
                }
            });
        },
        minLength: 3,
        select: function (event, ui) {
            log(ui.item ?
              "Selected: " + ui.item.label :
              "Nothing selected, input was " + this.value);
        },
        open: function () {
            $(this).removeClass("ui-corner-all").addClass("ui-corner-top");
        },
        close: function () {
            $(this).removeClass("ui-corner-top").addClass("ui-corner-all");
        }
    });
});