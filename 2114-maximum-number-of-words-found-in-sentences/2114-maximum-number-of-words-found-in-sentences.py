class Solution(object):
    def mostWordsFound(self, sentences):
        """
        :type sentences: List[str]
        :rtype: int
        """
        maximum=0
        for word in sentences:
            max_word = len(word.split())
            maximum = max(maximum,max_word)

        return (maximum)   
        