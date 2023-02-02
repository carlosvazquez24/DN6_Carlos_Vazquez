

var boton = document.getElementById("boton");
boton.addEventListener("click", validarFormulario);

var texto = document.getElementById("texto");
texto.addEventListener("keyup", function (e) {
    var codigoTecla = e.keyCode;
    if (codigoTecla == 13) {
        validarFormulario();
    }
});

function validarFormulario() {
    var texto = document.getElementById("texto").value;
    if (texto.length == 0 ) {
        alert("The ID field is empty");
    } else {
        abrirModal();
    }

}

function abrirModal() {
    $('#modal').modal('show');

    var idMiembro = document.getElementById("texto").value;
    var mensaje = document.getElementById("contenido");

    if ((nombreArchivoActual() == "MemberIn") || (nombreArchivoActual() == "MemberIn#") || (nombreArchivoActual() == "Attendance") ) {
        mensaje.innerHTML = "Registered entry for the Member with ID: " + idMiembro + " at: " +  moment(new Date()).format("HH:mm:ss") 
    } if ((nombreArchivoActual() == "MemberOut") || (nombreArchivoActual() == "MemberOut#") ) {
        mensaje.innerHTML = "Registred departure for the Member with ID:  " + idMiembro + " at: " + moment(new Date()).format("HH:mm:ss") 
    }
    
    
    setTimeout(cerrarModal, 4000);
}

function nombreArchivoActual() {
    var rutaAbsoluta = self.location.href;
    var posicionUltimaBarra = rutaAbsoluta.lastIndexOf("/");
    var rutaRelativa = rutaAbsoluta.substring(posicionUltimaBarra + 1, rutaAbsoluta.length);
    return rutaRelativa;
}

function cerrarModal() {
    $('#modal').modal('hide');
}
