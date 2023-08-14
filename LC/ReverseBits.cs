namespace LC
{
	//190. Reverse Bits
	public class ReverseBits
	{
		public static uint reverseBits(uint n)
		{
			string binaryString = "000000" + Convert.ToString(n, 2);
			var reversed = binaryString.ToCharArray().Reverse();
			binaryString = string.Join("", reversed);

			return Convert.ToUInt32(binaryString, 2);
		}
	}
}
