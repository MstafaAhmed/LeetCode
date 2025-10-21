/**
 * @param {string[]} words
 * @param {character} x
 * @return {number[]}
 */
var findWordsContaining = function(words, x) {
    let indx=[];
    let y=0;
    for(let i=0;i<words.length;i++){
        if(words[i].includes(x)){
            indx[y]=i;
            y++;
        }
    }
    return indx;
};