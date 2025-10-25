/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLastWord = function(s) {
    s=s.trimEnd();
    let arr=s.split(/\s+/);
    return arr[arr.length-1].length;
    
};