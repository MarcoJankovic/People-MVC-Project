

function getLastHuman(actionUrl) {
    $.get(actionUrl, function (respons) {
        console.log("Response", respons);
        document.getElementById("result").innerHTML = respons;
    });
}