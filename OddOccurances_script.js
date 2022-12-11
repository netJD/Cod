function solution(A) {

    let hash = {};

    for (let i = 0; i < A.length; i++) {
        if (!hash.hasOwnProperty(A[i]) || hash[A[i]] == 0) hash[A[i]] = 1;
        else hash[A[i]] = 0;

    }

    for (var key in hash) {
        if (hash.hasOwnProperty(parseInt(key))) {
            if (hash[parseInt(key)] == 1) {
                console.log(parseInt(key));
                unpairedElement = parseInt(key);
                return unpairedElement;
            }
        }
    }
    
}
