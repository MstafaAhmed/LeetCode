class Solution(object):
    def isMonotonic(self, nums):
        """
        :type nums: List[int]
        :rtype: bool
        """

        #write code here
        n = len(nums)
        first = nums[0]
        last = nums[n-1]
        if(n==0 | n==1): 
            return True
        if(first>last):
            for i in range(n-1):
                if(nums[i]<nums[i+1]):
                    return False

        if(first==last):
            for i in range(n-1):
                if(nums[i]<nums[i+1]):
                    return False
        
        if(first<last):
            for i in range(n-1):
                if(nums[i]>nums[i+1]):
                    return False
        return True