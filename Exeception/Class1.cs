using System;
using System.IO;
using System.Attribute;
public class CustomExceptionDemo
{
	public static void main(string[]args)
	{
		try {
            throw new UserAlreadyLoggedInException(); // custom Exception
        }
		catch(Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
    }
}

internal class UserAlreadyLoggedInException:Exception {

	//[obsolete] warnin to dontuse it  when run theprogram msg appear
	public UserAlreadyLoggedInException(string Msg):base(Msg) {
	
	
	}
}
