/* 
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

const loginForm = document.getElementById("login");
const loginButton = document.getElementById("submit");
const loginErrorMsg = document.getElementById("login-error-msg");

loginButton.addEventListener("click", (e) => {
    e.preventDefault();
    const username = loginForm.username.value;
    const password = loginForm.password.value;

    if (username === "user" && password === "123") {
        alert("You have successfully logged in.");
        location = "studentDashboard.html";
    } else {
        loginErrorMsg.style.opacity = 1;
    }
})
 