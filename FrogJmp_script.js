
function solution(x, y, d) {

    let jump = 0;
    let decimal = false;

    jump = y / d;

    if ((jump - Math.floor(jump)) !== 0) {
        decimal = true;
    }
    else {
        decimal = false;
    }

    if (decimal == true) {
        jump = Math.trunc(jump) + 1;
    }

    for (var i = 1; i < jump + 1; i++) {
        if ((i * d) + x >= y) {
            jump = i;
            jumpResult = jump;
        }
    }
    document.getElementById("p1").innerHTML = ("Jump: " + jumpResult);

    return jumpResult;
}
