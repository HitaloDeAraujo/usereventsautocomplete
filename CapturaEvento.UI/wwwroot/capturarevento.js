$(".evento").on('click', function (event) {

    var target = $(event.target);
    var evento = target.attr('data-evento-id');

    enviarEvento(evento);
});

function enviarEvento(data) {
    $.ajax({
        url: "http://localhost:65462/api/Eventos",
        dataType: "json",
        data: {
            nomeEvento: data
        },
        type: "GET",
        async: true,
        beforeSend: function () {
        },
        success: function (dados) {
            console.log(dados);
        },
        error: function (data, err) {
            alert(err);
        }
    });
}