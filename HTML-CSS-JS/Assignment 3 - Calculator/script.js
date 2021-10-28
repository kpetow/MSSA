var firstNum;
var secondNum;
var operation;
var defaultVal = 0;
var result;

var output = document.getElementById("output");

function digit(number){
     if(output.innerHTML == 0){
         output.innerHTML = number;
     }else{
         output.innerHTML += number;
    }
    firstNum = output.innerHTML;
    console.log(firstNum);
}
function logicDivide(){
    output.innerHTML = output.innerHTML + "/";
    document.getElementById("divide").disabled = true;
    document.getElementById("multiply").disabled = true;
    document.getElementById("subtract").disabled = true;
    document.getElementById("add").disabled = true;
    secondNum = output.innerHTML;
    secondNum = secondNum.split("/").pop();
}
function logicMultiply(){
    output.innerHTML = output.innerHTML + "*";
    document.getElementById("divide").disabled = true;
    document.getElementById("multiply").disabled = true;
    document.getElementById("subtract").disabled = true;
    document.getElementById("add").disabled = true;
}
function logicMinus(){
    output.innerHTML = output.innerHTML + "-";
    document.getElementById("divide").disabled = true;
    document.getElementById("multiply").disabled = true;
    document.getElementById("subtract").disabled = true;
    document.getElementById("add").disabled = true;
}
function logicAdd(){
    output.innerHTML = output.innerHTML + "+";
    document.getElementById("divide").disabled = true;
    document.getElementById("multiply").disabled = true;
    document.getElementById("subtract").disabled = true;
    document.getElementById("add").disabled = true;
}            
console.log(secondNum);

function calcOutput(){
    switch(){
        case add:
            output.innerHTML = firstNum + secondNum;
            break;
        case subtract:
            output.innerHTML = firstNum - secondNum;
            break;
        case divide:
            output.innerHTML = firstNum / secondNum;
            break;
        case multiply:
            output.innerHTML = firstNum * secondNum;
            break;
    }
}

function clearData(){
    output.innerHTML = defaultVal;
    document.getElementById("divide").disabled = false;
    document.getElementById("multiply").disabled = false;
    document.getElementById("subtract").disabled = false;
    document.getElementById("add").disabled = false;
}