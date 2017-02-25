$("#UserName").blur(function () {
    if ($("#UserName").val() =="" )
        $("#noUserName").css("display", "inline");
    else
        $("#noUserName").css("display", "none");
});

$("#Password").blur(function () {
    if ($("#Password").val() =="" )
        $("#noPassword").css("display", "inline");
    else
        $("#noPassword").css("display", "none");
});

$("#CPassword").blur(function () {
    if ($("#Password").val() != $("#CPassword").val())
        $("#PasswordError").css("display", "inline");
    else
        $("#PasswordError").css("display", "none");
});

$("#Group").blur(function () {
    if ($("#Group").val() == "")
        $("#noGroup").css("display", "inline");
    else
        $("#noGroup").css("display", "none");
});

$("#Contact").blur(function () {
    if ($("#Contact").val() == "")
        $("#noContact").css("display", "inline");
    else
        $("#noContact").css("display", "none");
});

