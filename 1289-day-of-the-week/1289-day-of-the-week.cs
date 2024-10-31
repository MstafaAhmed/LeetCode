public class Solution {
    public string DayOfTheWeek(int day, int month, int year) {
       // string [] days=["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];
        DateTime date = new DateTime(year, month, day);
        return date.DayOfWeek.ToString();
        
    }
}