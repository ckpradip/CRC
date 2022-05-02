using System;

public class CRC8Test
{
	public static void RunSnippet()
	{
		byte checksum;
		byte[] testVal = new byte[]
		{0xee, 0x01, 0x13, 0x00, 0x06, 0x1c, 0x00, 0x20,  0x1d, 0x00, 0x00};
		CRC8Calc crc_dallas = new CRC8Calc(CRC8_POLY.CRC8_DALLAS_MAXIM);
		checksum = crc_dallas.Checksum(testVal);
		WL(checksum);
		CRC8Calc crc = new CRC8Calc(CRC8_POLY.CRC8_CCITT);
		checksum = crc.Checksum(testVal);
		WL(checksum);
	}
	
	#region Helper methods
	
	public static void Main()
	{
		try
		{
			RunSnippet();
		}
		catch (Exception e)
		{
			string error = string.Format
			("---\nThe following error occurred while executing 
				the snippet:\n{0}\n---", e.ToString());
			Console.WriteLine(error);
		}
		finally
		{
			Console.Write("Press any key to continue...");
			Console.ReadKey();
		}
	}

	private static void WL(object text, params object[] args)
	{
		Console.WriteLine(text.ToString(), args);	
	}
	
	#endregion
}
