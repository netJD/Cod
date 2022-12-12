function solution(B) {
    let trueSum = 0;
    let missingNumber = 0;
    let n = B.length;

    let sum = (n + 1) * (n + 2) / 2;

    for (var i = 0; i < B.length; i++) {

        trueSum += B[i];

    }
    missingNumber = sum - trueSum;


    document.getElementById("p1").innerHTML = ("Missing Number: " + missingNumber);
    
}
