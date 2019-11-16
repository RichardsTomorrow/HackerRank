let operator = '';
let inputs = [];
function Display() {
    if(inputs[0]=== undefined){inputs[0]= '';}
    if(inputs[1]===undefined){inputs[1]= '';}
    document.getElementById('res').innerText = `${inputs[0]}${operator}${inputs[1]}`;
}
function actionSetValues(e) {
    var btn = e.target || e.srcElement;
    if (inputs.length === 0) {
        inputs[0] = document.getElementById(btn.id).innerHTML;
      } else if (operator.length === 0) {
        inputs[0] += document.getElementById(btn.id).innerHTML;
      } else if (inputs.length === 1 && operator.length > 0) {
        inputs[1] = document.getElementById(btn.id).innerHTML;
      } else if (inputs.length === 2 && operator.length > 0) {
        inputs[1] += document.getElementById(btn.id).innerHTML;
      }
    Display();
}
function actionClear(e) {
    var btn = e.target || e.srcElement;
    document.getElementById('res').innerHTML = '';
    operator = '';
    inputs = [];
}
function actionOperator(e) {
    var btn = e.target || e.srcElement;
    operator = document.getElementById(btn.id).innerHTML;
    Display();
}
function actionEquals(e) {
    var btn = e.target || e.srcElement; //this can be deleted
    let intAnswer;
    if(operator == '+'){
        intAnswer = parseInt(inputs[0],2) + parseInt(inputs[1],2);
    }else if ( operator == '-'){
        intAnswer = parseInt(inputs[0],2) - parseInt(inputs[1],2);
    }else if ( operator == '*'){
        intAnswer = parseInt(inputs[0],2) * parseInt(inputs[1],2);
    }else if ( operator == '/'){
        intAnswer = Math.floor(parseInt(inputs[0],2) / parseInt(inputs[1],2));
    }
    answer = intAnswer.toString(2);
    document.getElementById('res').innerHTML = `${answer}`
    inputs =[];
    operator = '';
}
document.getElementById('btn0').onclick = actionSetValues;
document.getElementById('btn1').onclick = actionSetValues;
document.getElementById('btnSum').onclick = actionOperator;
document.getElementById('btnSub').onclick = actionOperator;
document.getElementById('btnMul').onclick = actionOperator;
document.getElementById('btnDiv').onclick = actionOperator;
document.getElementById('btnClr').onclick = actionClear;
document.getElementById('btnEql').onclick = actionEquals;