// function validateInputs(){
// var un = document.getElementById("username");
// var pw = document.getElementById("password");
// var unerror = document.getElementById("unerror")
// var pwerror = document.getElementById("pwerror")
// const regx = /^[A-Za-z0-9._+\-\']+@[A-Za-z0-9.\-]+\.[A-Za-z]{2,}$/;

// if(!un.value){
//     unerror.innerHTML = "Username cannot be empty"
// }
// else if(!un.value.match(regx)){
//  unerror.innerHTML = "Invalid Username"
// }
// else{
//     unerror.innerHTML=""
// }
// if(!pw.value){
//     pwerror.innerHTML = "Password cannot be empty"
// }
// else{
//     pwerror.innerHTML=""
// }
// }

function validation(un,pw){
    const db =[{
        username:"mv@gmail.com",
        password:"1234"
    },
    {
        username:"vk@gmail.com",
        password:"1234"
    },
    {
        username:"mk@gmail.com",
        password:"1234"
    },
    {
        username:"sv@gmail.com",
        password:"1234"
    }
]
flag =0;
    for(i =0; i<db.length; i++){
        if(un!= db[i].username || pw!= db[i].password){
            flag=0
        }
        else{
            flag =1;
            break
        }
    }
    if(flag==0){
        return false
         
    }
    return true; 
}

module.exports = validation;