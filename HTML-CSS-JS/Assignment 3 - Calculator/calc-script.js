var output = document.getElementById("currentNum")
var previous = document.getElementById("prevNum")


var num1
var num2
var operator
var endCalc

function addNum(number) {
    if(output.innerHTML == 0){
        output.innerHTML = number
    }else{
        output.innerHTML += number
    }
    console.log("Current value is " + output.innerHTML)
}

function divide() {
    num1 = output.innerHTML;
    previous.innerHTML = num1 + "/";
    output.innerHTML = " "
    operator = "divide"
    document.getElementsByClassName('operator').disable = true 
}
function multiply() {
    num1 = output.innerHTML;
    previous.innerHTML = num1 + "*";
    output.innerHTML = " "
    operator = "multiply"
}
function minus() {
    num1 = output.innerHTML;
    previous.innerHTML = num1 + "-";
    output.innerHTML = " "
    operator = "minus"
}
function add() {
    num1 = output.innerHTML;
    previous.innerHTML = num1 + "+";
    output.innerHTML = " "
    operator = "add"
}

// function addOperator(operator) {
//     switch (operator){
//         case 'divide': 
//             num1 = output.innerHTML;
//             previous.innerHTML = num1 + "/";
//             output.innerHTML = " "
//             operator = "divide"
//             break
//         case 'multiply': 
//             num1 = output.innerHTML;
//             previous.innerHTML = num1 + "*";
//             output.innerHTML = " " 
//             operator = "multiply"
//             break
//         case 'minus': 
//             num1 = output.innerHTML;
//             previous.innerHTML = num1 + "-";
//             output.innerHTML = " " 
//             operator = "minus"
//             break
//         case 'add': 
//             num1 = output.innerHTML;
//             previous.innerHTML = num1 + "+";
//             output.innerHTML = " " 
//             operator = "add"
//             break
//         default:
//             console.log("You need to choose an operation")        
//     }
//     console.log("Current operation is " + operator)
//     console.log("Previous value is " + previous.innerHTML)
// }

function compute() {
    num1 = parseFloat(num1)
    num2 = parseFloat(output.innerHTML)
    console.log(num1)
    console.log(num2)
    console.log("Current operation is " + operator)
    switch (operator){
        case "divide": 
            output.innerHTML = num1 / num2
            previous.innerHTML += num2
            break
        case "multiply": 
            output.innerHTML = num1 * num2
            previous.innerHTML += num2
            break
        case "minus": 
            output.innerHTML = num1 - num2
            previous.innerHTML += num2
            break
        case "add": 
            output.innerHTML = num1 + num2
            previous.innerHTML += num2 
            break
        default:
            console.log("not working bro")  
    }
}

function allClear(){
    previous.innerHTML = " "
    output.innerHTML = "0"
}
function backspace(){
    output.innerHTML = output.innerHTML.slice(0, -1);
}
