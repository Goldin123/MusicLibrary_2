

function getLog() {
    //Show popup modal after clicking 'View Renewal Log' link.(in partial '_RegInfo')
    $('#RenewalModal').modal('show');
}
$(document).ready(function () {
   

    if (getParameterByName("sitecode") != "") {
        //Popup Modal on first load of rereg page.
        $('#myModal').modal('show');
    }
    else {
        $("#")
    }

    

    //if (getParameterByName("auth") == "1") {
    //    if (getParameterByName("err") == "1") {
    //        alert("Unexpected error occurred when generating the AuthCode. Please check the following fields if they are correct. Expiry Date, Pervasive Database, Number of Employees/User's or alternatively contact the System Administrator.");
    //    }
    //    else {

    //        alert("Authcode was generated successfully.\n" + getParameterByName("mail"));
    
    //Number of employees validation for modules listed in the case.
    //if (getParameterByName("errEmp") != "") {
    //    var error = getParameterByName("errEmp");
    //    switch (error) {
    //        case "RESS":
    //            alert("Please select Self Service number of employees");
    //            break;
    //        case "RSIT":
    //            alert("Please select Site Licence number of employees");
    //            break;
    //        case "RSIT5":
    //            alert("Please select 5in1 Site Licence number of employees");
    //            break;
    //        case "RHR":
    //            alert("Please select HR number of employees");
    //            break;
    //        case "RSITA":
    //            alert("Please select Advantage Site Licence number of employees");
    //            break;
    //    }
    //}
    //if (getParameterByName("auth") == "1") {
    //    $("#NewAuthorizationCode").css('color', 'red');
    //    $("#ProductCode").css('color', 'red');
    //}

    var strCellPhone = null; var strCompanyName = null; var strProductCode = null; var strAuthCode = null; var strSiteCode = null; var strUserID = null;
    $("#btnSMSAuthCode").click
    (function () {

        if (getParameterByName("uid") != "")
            strUserID = getParameterByName("uid");

        strCellPhone = $('#Cellphone').val();
        strCompanyName = $('#CompanyName').val();
        strProductCode = $('#ProductCode').val();
        strAuthCode = $('#NewAuthorizationCode').val();
        strSiteCode = $('#SiteCode').val();
        if (strCellPhone != "") {
            var URL = '@Url.Action("SMS", "Product")';
            $.post(URL, { CellPhone: strCellPhone, CompanyName: strCompanyName, ProductCode: strProductCode, AuthCode: strAuthCode, SiteCode: strSiteCode, UserID: strUserID }, function (data) {
                if (data != null) {
                    alert(data);
                }
            }, "json");
        }
        else {
            alert("Invalid Cellphone number.")
        }

    });

    $("#btnSubmit").click(function (e) {
        var msg = "";
        if ($("#AccesCode").val() == "")
            msg = "Invalid Access Code."

        if ($("#Email").val() == "")
            msg = "\nInvalid E-mail."

        if ($("#ExpiryDate").val() == "")
            msg = msg + "\nInvalid Expiry Date."

        if ($("#PerDBVersionCode").val() == "")
            msg = msg + "\nInvalid Pervasive Version DB."

        if ($("#Country").val() == "")
            msg = "Invalid Country."

        if (msg != "") {
            e.preventDefault(); // this will prevent from submitting the form.
            alert(msg + "\nNB: This can only be corrected on the CRM customer profile.");
        }
    });

    function getParameterByName(name) {
        name = name.replace(/[\[]/, "\\\[").replace(/[\]]/, "\\\]");
        var regexS = "[\\?&]" + name + "=([^&#]*)",
            regex = new RegExp(regexS),
            results = regex.exec(window.location.href);
        if (results == null) {
            return "";
        } else {
            return decodeURIComponent(results[1].replace(/\+/g, " "));
        }
    }
});
