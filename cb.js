$(document).ready(function () {
    $("#sub").click(function () {
        var num = parseInt($('#num').val())
        $.post('../Home/CubeAjax', {
            number: num
        }, function (data) {
            if (data[0].mess == 1) {
                alert("Cube: " + data[0].cube + "perfect:  " + data[0].perfect);
            }
        });
    });
});