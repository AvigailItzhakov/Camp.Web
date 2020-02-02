$(() => {

    

    $("#allergyCheckBox").click(function () {
        var checked_status = this.checked;
        $("#allergyCheckBox").val("true");
        if (checked_status == true) {
            $("#alergyFood").removeAttr("disabled");
        } else {
            $("#alergyFood").attr("disabled", "disabled");
        }
    });
   
})