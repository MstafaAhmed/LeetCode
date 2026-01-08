class Solution(object):
    def reversePrefix(self, s, k):
        """
        :type s: str
        :type k: int
        :rtype: str
        """
        new = s[:k]
    
        return(new[::-1] + s[k:])