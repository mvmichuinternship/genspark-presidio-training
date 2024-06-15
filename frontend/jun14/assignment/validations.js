var professions = ["Engineer", "Doctor", "Teacher", "Accountant", "Pani puri shop owner"];

function addProfession() {
    var newProfession = document.getElementById("profession").value.trim();

    if (newProfession && !professions.includes(newProfession)) {
        professions.push(newProfession);
        var option = document.createElement("option");
        option.value = newProfession;
        document.getElementById("professions").appendChild(option);
    }
}

function validateAllFields() {
    var errors = [];

    var nameError = validateName();
    if (nameError) {
        errors.push(nameError);
    }

    var phoneError = validatePhone();
    if (phoneError) {
        errors.push(phoneError);
    }

    var emailError = validateEmail();
    if (emailError) {
        errors.push(emailError);
    }

    var dobError = validateDob();
    if (dobError) {
        errors.push(dobError);
    }


    return errors;
}

var buttonClick=()=> {
    var myDiv = document.getElementById("buttondiv");
    addProfession()
    var errors = validateAllFields();
    myDiv.innerHTML = errors.join("<br>");

}
var validateName = () => {
    var txtName = document.getElementById("name");
    var errMsg = document.getElementById("errorMsgName");
    if (!txtName.value) {
        errMsg.innerHTML = "Cannot be empty";
        return "Name cannot be empty";
    }
    else {
        errMsg.innerHTML = "";
        errMsg.classList.remove("errmsg");
    }
}

var validatePhone = () => {
    var txtPhone = document.getElementById("phone");
    var errMsg = document.getElementById("errorMsgPh");
    if (!txtPhone.value) {
        errMsg.innerHTML = "Cannot be empty";
        return "Phone cannot be empty";
    }
    else if (txtPhone.value.length <10 || txtPhone.value.length >10) {
        errMsg.classList.add("errmsg");
        errMsg.innerHTML = "Invalid entry for Phone";
        return "Invalid entry for Phone";
    }
    else {
        errMsg.innerHTML = "";
        errMsg.classList.remove("errmsg");

    }
}

var validateEmail = () => {
    var txtEmail = document.getElementById("email");
    var errMsg = document.getElementById("errorMsgEm");
    var emailRegex = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    if (!txtEmail.value) {
        errMsg.innerHTML = "Cannot be empty";
        return "Email cannot be empty";
    }
    else if(!emailRegex.test(txtEmail.value)){
        errMsg.innerHTML = "Invalid Email";
        return "Invalid Email";
    }
    else {
        errMsg.innerHTML = "";
        errMsg.classList.remove("errmsg");
    }
}

var validateDob = () => {
    var txtDob = document.getElementById("dob");
    var errMsg = document.getElementById("errorMsgDob");
    var ageInput = document.getElementById("age");

    if (!txtDob.value) {
        errMsg.innerHTML = "Cannot be empty";
        return "Dob cannot be empty";
    }
    else {
        errMsg.innerHTML = "";
        errMsg.classList.remove("errmsg");
        var dob = new Date(txtDob.value);
        var today = new Date();
        var age = today.getFullYear() - dob.getFullYear();
        // var monthDiff = today.getMonth() - dob.getMonth();
        // if (monthDiff < 0 || (monthDiff === 0 && today.getDate() < dob.getDate())) {
        //     age--;
        // }

        ageInput.value = age;
    }
}


