const users = {
    username: "Juan",
    password: "1234"
}

function validatePassword() {
    var username = document.getElementById('username').value;
    var password = document.getElementById('password').value;
    var message = document.getElementById('message');

    if(password == users.password && username == users.username) {
        message.innerHTML = "Correct password";
        message.className = "correct";
    } else if (password == "" || username == "") {
        message.innerHTML = "Both fields must be filled";
        message.className = "missing";
    }
    else {
        message.innerHTML = "Wrong username or password";
        message.className = "wrong";
    }
}