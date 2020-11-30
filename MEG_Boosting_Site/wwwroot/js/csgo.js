$(document).ready(function() {
    $(".ranks, .ranks2").on('change',function(event) {
        var total = [];
        $.each($(".ranks option:selected"), function() {
            total.push($(this).val());
        });
        $.each($(".ranks2 option:selected"), function() {
            total.push($(this).val());
        });



        total = parseFloat(total[0]) + parseFloat(total[1])
        if (total === 0) {
            $('#amount').val('');
        } else {
            $('#amount').val(total);
        }
    });
});    
