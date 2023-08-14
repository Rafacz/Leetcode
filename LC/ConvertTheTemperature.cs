namespace LC
{
	//2469. Convert the Temperature
	public class ConvertTheTemperature
	{
		public static double[] ConvertTemperature(double celsius)
		{
			double[] result = { celsius + 273.15, celsius * 1.80 + 32.00 };
			return result;
		}
	}
}
