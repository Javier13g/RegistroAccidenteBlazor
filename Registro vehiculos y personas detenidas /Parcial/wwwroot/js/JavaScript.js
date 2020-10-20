function AlertBorrarVehiculo() {
    /*alert("EL ACCIDENTE HA SIDO ELIMINADO CON EXITO"); */
    alertify.alert('Exito', function () { alertify.success('Vehiculo borrado con exito'); });

}

function AlertGuardarVehiculo() {
    alertify.alert('Exito!', function () { alertify.success('Vehiculo guardado con exito'); });

}

function AlertEditarrVehiculo() {
    alertify.alert('Exito!', function () { alertify.success('Vehiculo actualizado con exito'); });

}

function AlertBorrarPersona() {
    alertify.alert('Exito', function () { alertify.success('Persona borrado con exito'); });
}

function AlertGuardarPersona() {
    alertify.alert('Exito', function () { alertify.success('Persona guardada con exito'); });
}

function AlertEditarPersona() {
    alertify.alert('Exito!', function () { alertify.success('Persona actualizada con exito'); });

}

function FullCounter() {
    const mensaje = document.getElementById('mensaje');
    const contador = document.getElementById('contador');

    mensaje.addEventListener('input', function (e) {
        const target = e.target;
        const longitudMax = target.getAttribute('maxlength');
        const longitudAct = target.value.length;
        contador.innerHTML = `${longitudAct}/${longitudMax}`;
        if (target.value.length == 100) {
            alertify.alert('Advertenciap', function () { alertify.error('Ha superado el limite de caracteres'); });
        }
    });
}