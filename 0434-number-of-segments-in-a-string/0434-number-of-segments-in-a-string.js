/**
 * @param {string} s
 * @return {number}
 */
var countSegments = function(s) {if (!s.trim()) return 0;  // handle empty or all-space strings
  return s.trim().split(/\s+/).length;  // split by one or more spaces

};