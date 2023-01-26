
function fecha() {
    var fecha = moment(new Date).format("DD-MM-YYYY");
    return fecha
}


let Customer = [
    {
        "nombreCliente": "Chano",
        "apellidoCliente": "Velazquez",
        "tipoMensualidad": "normal",
        "fechaIngreso" : fecha()

    },
    {
        "nombreCliente": "Juan",
        "apellidoCliente": "Sanchez",
        "tipoMensualidad": "estudiante",
        "fechaIngreso": fecha()

    },

    {
        "nombreCliente": "Diana",
        "apellidoCliente": "Mendez",
        "tipoMensualidad": "normal",
        "fechaIngreso": fecha()

    },

    {
        "nombreCliente": "David",
        "apellidoCliente": "Pot",
        "tipoMensualidad": "estudiante",
        "fechaIngreso": fecha()

    }

]

var lista = document.getElementById("lista");

for (var i = 0; i < Customer.length; i++) {
    lista.innerHTML = lista.innerHTML + "<li>" + "<div>" + Customer[i].nombreCliente + "</div>" + "<div>" + Customer[i].apellidoCliente + "</div>" + "<div>" + Customer[i].fechaIngreso + "</div>" + "<div>" + Customer[i].tipoMensualidad + "</div>" + "</i>"
}



