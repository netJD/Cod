/*
example
9 => 1001    gaps: 2  Maxgap:2
1041 => 10000010001    gaps: 5,3  Maxgap:5

Edge:
1. 1111
2. 0000
=> 0

Diagram:
10000010001    
i
j

10000010001  
i
      j
store gap = 5
set i = j

10000010001 
      i
      j
10000010001 
      i
          j
store gap = 3
set i = j
i = 7
j = 11
j -i = 4 sub -1 to get result in gap = 3


Steps:
1. have pointers i and j set to position 0 of binary number
2. increment j pointer until it hits a 1 in binary sequence
3. store j - i - 1 to get the gap
4. set i = j
5. repeat until end of array.
 */


function solution(N) {
    let binaryN = (N >>> 0).toString(2);
    console.log(binaryN);
    for (let i = 0; i < binaryN.length; i++) {
        for (let j = 0; j < binaryN.length; j++) {
            if (binaryN[i] == 1 && binaryN[j] == 1 ) {
                if (maxGap < j - i - 1) {
                    maxGap = j - i - 1;
                }
                i = j;
            }
        }

    }
    return maxGap;
}
