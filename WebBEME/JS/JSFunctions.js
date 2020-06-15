function validar_rut(source, arguments){                                                

    var cedula = arguments.Value; 
    var dv = cedula
        .charAt(cedula.length-1)
        .toUpperCase();
         
    var total = 0; 
    var mul = 2;

    for (i=cedula.length-3; i>=0 ; i--){
        total = total + parseInt(cedula.charAt(i)) * mul;
        mul = mul==7 ? 2 : mul+1;
    };

    var rDv = (11 - total % 11);
    rDv = rDv == 10 ? 'K' : rDv;
    rDv = rDv == 11 ? '0' : rDv;
    arguments.IsValid = (dv == rDv);

}

function ClickEnter(objTextBox,objBtnID)
{
    if(window.event.keyCode==13)
    {
        document.getElementById(objBtnID).focus();
        document.getElementById(objBtnID).click();
    }
}