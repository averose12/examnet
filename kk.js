
$().ready(function () {
    //$('#sub').submit(function (event) { // Add 'event' parameter to the submit function

    //    event.preventDefault(); // Prevent the default form submission

    //    var number = parseInt($('#number').val()); // Correct the syntax for parseInt
    //    $.post('../Home/CubeChecker', { // Add comma between the URL and data object
    //        number: number
    //    }, function (data) {
    //        $('#result').html(data[0].message); // 'data' instead of 'response', and '.message' to access the message property
    //    });
    //});
        $("#btn").click(function () {
            var num3 = parseInt($("#num3").val());

            $.post('../Home/Loopajax', {


                n3: num3,

            }, function (data) {
                if (data[0].mess == 1) {
                    alert("\nPERFECT: " + data[0].perfect + "\nFACTORIAL: " + data[0].factorial)
                }

            });


        })

    });

