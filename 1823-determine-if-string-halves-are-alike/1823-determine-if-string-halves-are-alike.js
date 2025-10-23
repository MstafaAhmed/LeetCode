/**
 * @param {string} s
 * @return {boolean}
 */
var halvesAreAlike = function(s) {
    let a=s.slice(0,(s.length/2));
    a=a.toLowerCase();
    let b=s.slice((s.length/2));
    b=b.toLowerCase();

    let vowel="aeoui"
    let out1=0;
    let out2=0;

    for(let i of a){
        if(vowel.includes(i)){
            out1++;
        }
    }
     for(let i of b){
        if(vowel.includes(i)){
            out2++;
        }
    }
    return out1==out2 ;
};