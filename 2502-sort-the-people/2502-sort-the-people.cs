public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
        List<(int Height, string Name)> people = new List<(int, string)>();

        for (int i = 0; i < heights.Length; i++) {
            people.Add((heights[i], names[i]));
        }

        people.Sort((x, y) => y.Height.CompareTo(x.Height));

        string[] result = new string[names.Length];
        for (int i = 0; i < people.Count; i++) {
            result[i] = people[i].Name;
        }

        return result;
    }
}