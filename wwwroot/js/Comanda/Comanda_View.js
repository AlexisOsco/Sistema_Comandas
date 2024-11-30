
$(document).ready(function (e) {


    F_Mostrar_Pagina('MESAS');


    $(window).click(function (e) {
        console.log();
    })

});



function F_Mostrar_Pagina(pagina) {
    let Mesas = $("#mesas");
    let Orden = $("#orden");

    switch (pagina) {
        case "MESAS":
            Orden.hide();
            Mesas.show();
            break;
        case "ORDEN":
            Mesas.hide();
            Orden.show();
            break;
    }

}

function F_SeleccionarPiso(element) {
    let ID_anterior = ''

    $("#mesas div.centrado div.grid-mesas").each(function (index, elemnt) {
        
        if ($(elemnt).hasClass("activo")) {

            ID_anterior = $(elemnt).attr("id");
            if (ID_anterior != element) {
                $(elemnt).slideUp();
                $(elemnt).removeClass("activo");
            }
           
        }
    })

    if (ID_anterior != element) {
        $(`#${element}`).addClass("activo");
        $(`#${element}`).slideDown();
    }
}

function F_Seleccionar_Lugar(mesa, piso) {
    $("#mesas").hide();
    $("#orden").slideDown();

    F_Inicar_Orden(mesa, piso);
}

function F_Inicar_Orden(mesa, piso) {
    console.log("usted a seleccionado la mesa :" + mesa + ", del piso ", piso);
}