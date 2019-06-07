$(function () {
    var tokenKey = "tokenInfo";
    $('#logOut').click(function (e) {
        e.preventDefault();

        $.ajax({
            type: 'POST',
            url: '/api/Account/Logout',
            beforeSend: function (xhr) {
                var token = window.localStorage.getItem(tokenKey);
                xhr.setRequestHeader("Authorization", "Bearer " + token);
            },
            success: function () {
                // удаляем в хранилище sessionStorage токен доступа
                window.localStorage.removeItem(tokenKey);
                console.log("Logout success");
                window.location.reload(false);
            },
            error: function (data) {
                alert('Logout не пройдена' + data.statusText + JSON.parse(data.responseText).Message);
            }
        });
    });
})