'use strict';

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', inputStdin => {
    inputString += inputStdin;
});

process.stdin.on('end', _ => {
    inputString = inputString.trim().split('\n').map(string => {
        return string.trim();
    });
    
    main();    
});

function readLine() {
    return inputString[currentLine++];
}

/*
 * Complete the reverseString function
 * Use console.log() to print to stdout.
 */
function reverseString(s) {
    let answer;
    try{
        answer = s.split('').reverse().join('');
    }
    catch (error){
        console.log(error.message);
        answer = s;
    }
    finally{
        console.log(answer);
    }
}


function main() {
    const s = eval(readLine());
    
    reverseString(s);
}