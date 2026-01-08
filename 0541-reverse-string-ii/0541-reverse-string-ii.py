class Solution(object):
    def reverseStr(self, s, k):
        s = list(s)  # convert string to list for in-place modification
        for i in range(0, len(s), 2*k):
            s[i:i+k] = reversed(s[i:i+k])  # reverse first k characters of every 2k block
        return "".join(s)
