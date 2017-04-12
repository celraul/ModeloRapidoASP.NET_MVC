var Util = {
    somenteNumeros: function (e) {
        var tecla = (window.event) ? event.keyCode : e.which;
        if ((tecla > 47 && tecla < 58)) return true;
        else {
            if (tecla == 46 || tecla == 0) return true;
            else return false;
        }
    },

    getCookie: function (cname) {
        var name = cname + "=";
        var ca = document.cookie.split(';');
        for (var i = 0; i < ca.length; i++) {
            var c = ca[i];
            while (c.charAt(0) == ' ') {
                c = c.substring(1);
            }
            if (c.indexOf(name) == 0) {
                return c.substring(name.length, c.length);
            }
        }
        return "";
    },

    removeCoockie: function (cname) {
        expireAt = new Date;
        expireAt.setMonth(expireAt.getMonth() - 1);

        document.cookie = cname + "=;expires=" + expireAt.toGMTString();
    },
    maskDouble: function (obj) {
        obj.value = obj.value.replace(/\D/g, "")
        obj.value = obj.value.replace(/(\d)(\d{1,2}$)/, "$1.$2")

        if (parseInt(obj.value) > 100) {
            obj.value = "";
        }

    },

    maskDoubleSemValorMaximo: function (obj) {
        obj.value = obj.value.replace(/\D/g, "")
        obj.value = obj.value.replace(/(\d)(\d{1,2}$)/, "$1.$2")
    }
}



jQuery(document).ready(function () {

    if (jQuery("form").length > 0) {

        jQuery(".confirm-alert").each(function (event) {
            $(this).confirm({
                title: "Confirmação",
                text: "Deseja realizar esta ação?",

                confirm: function (event) {
                    var form = event.parents('form:first');

                    form.submit();
                },

                cancel: function (button) {
                },
                confirmButton: "Sim",
                cancelButton: "Não"
            });
        });
    }

    $('.paginacao').DataTable({
        "info": false,
        "searching": false,
        "lengthChange": false,
        "ordering": false,
        "language": {
            "lengthMenu": "registros de exibição _MENU_ por página",
            "zeroRecords": "Sem dados para exibir - desculpe!",
            "info": "Mostrando _PAGE_ de _PAGES_",
            "infoEmpty": "Não há registros disponíveis",
            "infoFiltered": "(filtrada dos registros totais _MAX_)",
            "oPaginate": {
                "sFirst": "Primeiro",
                "sPrevious": "Anterior",
                "sNext": "Próximo",
                "sLast": "Último"
            }
        },
        'aoColumnDefs': [{
            'bSortable': false,
            'aTargets': 0
        }]

    });

    var trClick = $(".dataTable tr");
    if (trClick.find('a').length > 0 && trClick.find('a').attr('data-toggle') == undefined) {

        var table = $('.dataTable').DataTable();
        table.on('draw', function () {
            clickTr();
        });

        clickTr();
    }

    function clickTr() {
        var trClick = $(".dataTable tr");
        if (trClick.find('a').length > 0 && trClick.find('a').attr('data-toggle') == undefined) {

            trClick.find('a').hide();
            $(".dataTable th:last").hide();

            trClick.attr('style', 'cursor:pointer');

            $(".dataTable").addClass('table-hover');
            $(".dataTable tr").on("click", function () {
                if ($(this).find('a').length > 0) {
                    document.location.href = $(this).find('a').attr('href');
                }
            });
        }
    }


    linkTrTable();
    if ($('.dataTable').length > 0) {

        var table = $('.dataTable');

        table.DataTable();
        table.on('draw.dt', function () {
            linkTrTable();
        });
    }


});


function linkTrTable() {

    $(".link-tr").attr('style', 'cursor:pointer');
    $(".table").addClass('table-hover');

    $(".link-tr").click(function () {
        window.document.location = $(this).data("href");

    });
}



