//Scrip for the login partial.

$(function () {
    $('#loader').hide();
});

$("#form").submit(function (e) {
    $("#myLoadingElement").show();
});

var onSuccess = function (result) {
    if (result.RedirectUrl) {
        $('#loader').show();
        // if the server returned a JSON object containing an url
        // property we redirect the browser to that url
        window.location.href = result.RedirectUrl;
    }
}

$(".nav li a").click(function () {
    $('#loader').show();
});