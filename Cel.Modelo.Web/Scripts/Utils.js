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

        var confirmsAlert = jQuery(".confirm-alert");

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
                cancelButton: "Não",
                confirmButton: "Sim"
               
            });
        });
    }


});
