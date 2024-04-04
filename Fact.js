$(document).ready(function () {
    $('#sub').click(function () {
        var number = parseInt($('#num').val());
        var per = "";
        var factorial = 1;
        
        var sum = 0;

        for (var i = 1; i <= number; i++) {
            factorial *= i;
        }
        
        for (var i = 1; i < number; i++) {
            if (number % i == 0) {
                sum += i;
            }
        }

        if (number == sum) {
            per = "PERFECT";
        } else {
            per = "NOT PERFECT";
        }

        $.post('../Home/Facts', {
            number: number,
            factorial: factorial, // Pass factorial to the controller
            perfect: per // Pass perfect status to the controller

        },
            function (data) {
                

                if (data[0].mess == 1) {
                    alert("Factorial: " + data[0].factorial + " Perfect: " + data[0].perfect);
                } else {
                    alert("Error occurred or invalid data received.");
                }
            });
    });
});
