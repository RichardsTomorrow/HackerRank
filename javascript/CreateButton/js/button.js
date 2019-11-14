var clickMeButton = document.createElement('button');
let num = 0;
clickMeButton.innerHTML = num;
clickMeButton.id = 'btn';
document.body.appendChild(clickMeButton);
clickMeButton.onclick = function() {
    num++;  
    clickMeButton.innerHTML++;
};