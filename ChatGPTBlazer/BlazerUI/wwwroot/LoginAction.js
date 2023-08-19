function loginPage(form) {
    if (form.username.value == "test") {
        if (form.password.value == "test") {
            location = "/LoginTest"
        }
        else {
            alert("Incorrect detail Password")
        }

    }
}