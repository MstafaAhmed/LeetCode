public class Solution {
    public int BuyChoco(int[] prices, int money) {
        Array.Sort(prices);
        int sum =prices[0]+prices[1];
        if(money>=sum)
        {
            return (money-sum);
        }else{return money;}
    }
}