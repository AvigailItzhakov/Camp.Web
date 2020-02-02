$(() => {

    $("#yearButton").on('click', function () {
        const year = $("#year").val();
        $.get('/home/submitYear', { year }, function () {

        })
    })

   

})