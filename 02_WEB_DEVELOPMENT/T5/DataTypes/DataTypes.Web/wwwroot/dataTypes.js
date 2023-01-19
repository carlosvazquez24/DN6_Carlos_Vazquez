
var buttons = document.getElementsByTagName("button");

for (var i = 0; i < buttons.length; i++) {
    buttons[i].addEventListener("click", buttonClick);
}

function buttonClick(evento) {
    var currentButton = evento.currentTarget;
    var listClasses = currentButton.classList;

    var isGreen = false;
    for (var i = 0; i < listClasses.length; i++) {

        if (listClasses[i] == "green") {
            isGreen = true;
            break;
        } 

    }

    if (isGreen == true) {
        currentButton.className = "btn red";
    } else {
        currentButton.className = "btn green";
    }


    var table = document.getElementById("sampleTable");

    table.innerHTML = table.innerHTML + "<tr><td>" + currentButton.getAttribute("name") + "</td><td>" + new Date + "</td></tr>"
   
}

