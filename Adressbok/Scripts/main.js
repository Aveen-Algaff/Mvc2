$(document).ready(function () {
    form.validate();
    $.ajax({
        method: "Get",
        url: "/Adressbok/Delete",
        success: function (data) {
            $("Index").html(data);
        }
    });
    var form = $("form");
    form.submit(function (e) {
        e.preventDefault();

        if (form.valid()) {
            $.ajax({
                method: "POST",
                url: "/Adressbok/Create",
                data: new FormData(document.getElementsByTagName("form")[0]),
                success: function (data) {
                    $("div#result").html(data);
                },
                processData: false,
                contentType: false
            });
        }
    });
})