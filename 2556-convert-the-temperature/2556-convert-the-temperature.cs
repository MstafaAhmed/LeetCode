public class Solution {
    public double[] ConvertTemperature(double celsius) 
    {
         double Kelvin = celsius+273.15;
        double Fahrenheit = celsius*1.8+32.00;
        return [Kelvin,Fahrenheit];
    }
}