$(document).ready(function () {

    function changeEdition() {
        var yearId = $("#CurrentViewEdition").val();
        /* $.post("Home/ChangeEdition", { "Edition": yearId });
         var BaseUrl = 'https://' + top.location.host;*/

        $.ajax({
            type: 'POST',
            url: BaseUrl + '/Home/ChangeEdition',
            data: ({ "Edition": yearId }),
            success: function (resp) {

            }
        });

    };

    $("#CurrentViewEdition").change(function () { changeEdition(); });
});



function subscribe() {
    $.ajax({
        type: 'POST',
        url: "/MailChimp/Subscribe",
        data: ({ "Email": $('#Email').val() }),
        success: function (resp) {
            $('#Email').hide();
            $('#result').show();
        }
    });
}