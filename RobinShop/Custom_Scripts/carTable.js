$(document).ready(function() {

    $.ajax({
        url: 'Cars/CarTable/',
        success: function(result) {
            $('#carTable').html(result);
        }
    });


});
