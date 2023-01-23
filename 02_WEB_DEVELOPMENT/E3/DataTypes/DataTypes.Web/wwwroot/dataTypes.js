
var buttons = document.getElementsByTagName("button");

for (var i = 0; i < buttons.length; i++) {
    buttons[i].addEventListener("click", buttonClick);
}



(function () {

    document.getElementById("button1").addEventListener("click", function () {
        var options = {
            style :{
                main : {
                    background: "#364685",
                    color: "#fff",
                },

            },
        };


        iqwerty.toast.toast("Hello world", options);
    })

    var bv = new Bideo();
    bv.init({
        // Video element
        videoEl: document.querySelector('#background_video'),

        // Container element
        container: document.querySelector('body'),

        // Resize
        resize: true,

        // autoplay: false,

        // Array of objects containing the src and type
        // of different video formats to add
        src: [
            {
                src: '/lib/Bideo/night.mp4',
                type: 'video/mp4'
            }
        ],

        // What to do once video loads (initial frame)
        onLoad: function () {
            document.querySelector('#video_cover').style.display = 'none';
        }
    });
}());






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

    table.innerHTML = table.innerHTML + "<tr><td>" + currentButton.getAttribute("name") + "</td><td>" + moment(new Date).format("DD-MM-YYYY hh:mm:ss") + "</td></tr>"
   
}
