var output = document.getElementById("currentNum")
var previous = document.getElementById("prevNum")
var divBtn = document.getElementsByClassName("operator")[0]
var multBtn = document.getElementsByClassName("operator")[1]
var minBtn = document.getElementsByClassName("operator")[2]
var addBtn = document.getElementsByClassName("operator")[3]

output.innerHTML = 0

var num1
var num2
var operator
var endCalc = false
console.log("endCalc is " + endCalc)

function allClear(){
    previous.innerHTML = " "
    output.innerHTML = "0"
    divBtn.disabled = true
    multBtn.disabled = true
    minBtn.disabled = true
    addBtn.disabled = true
    endCalc = false
    num1 = null
    num2 = null
}
function addNum(number) {
    console.log("endCalc is " + endCalc)
    if(endCalc == false){
        if(output.innerHTML == 0){
            output.innerHTML = number
        } else {
            output.innerHTML += number
        }
    } else {
        allClear()
        output.innerHTML = number
        console.log("calculator cleared")
    }
    divBtn.disabled = false
    multBtn.disabled = false
    minBtn.disabled = false
    addBtn.disabled = false
}

// function addNum(number) {
//     console.log("endCalc is " + endCalc)
//     if(output.innerHTML == 0){
//         output.innerHTML = number
//         }else{
//         output.innerHTML += number
//         }        
//     divBtn.disabled = false
//     multBtn.disabled = false
//     minBtn.disabled = false
//     addBtn.disabled = false
// }

function divide() {
    num1 = output.innerHTML;
    console.log("num1 is currently " + num1)
    previous.innerHTML = num1 + "/";
    output.innerHTML = " "
    operator = "divide"
    divBtn.disabled = true
    multBtn.disabled = true
    minBtn.disabled = true
    addBtn.disabled = true
    endCalc = false
    
}
function multiply() {
    num1 = output.innerHTML;
    previous.innerHTML = num1 + "*";
    output.innerHTML = " "
    operator = "multiply"
    divBtn.disabled = true
    multBtn.disabled = true
    minBtn.disabled = true
    addBtn.disabled = true
    endCalc = false
}
function minus() {
    num1 = output.innerHTML;
    previous.innerHTML = num1 + "-";
    output.innerHTML = " "
    operator = "minus"
    divBtn.disabled = true
    multBtn.disabled = true
    minBtn.disabled = true
    addBtn.disabled = true
    endCalc = false
}
function add() {
    num1 = output.innerHTML;
    previous.innerHTML = num1 + "+";
    output.innerHTML = " "
    operator = "add"
    divBtn.disabled = true
    multBtn.disabled = true
    minBtn.disabled = true
    addBtn.disabled = true
    endCalc = false
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
    num1 = output.innerHTML
    endCalc = true
    console.log("endCalc is " + endCalc)
    console.log("num1 is " + num1)
    console.log("num2 is " + num2)
}
function backspace(){
    if(output.innerHTML > 0){
    output.innerHTML = output.innerHTML.slice(0, -1);
    } else {
        output.innerHTML = 0
    }
}
