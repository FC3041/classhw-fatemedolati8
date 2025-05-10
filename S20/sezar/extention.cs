public static class EXT
{
	public static string Encoder(this string str)
	{
		string s="";
		foreach(char c in str)
		{
			string s1="xyzXYZ";
			string s2="abcABC";
			for(int i=0; i<6;i++)
			{
				if(c==s1[i])
				{
					s+=s2[i];
				}
				

			}
			if(c!='x'&&c!='y'&&c!='z'&&c!='X'&&c!='Y'&&c!='Z')
			{
				s+=(char)(c+3);
			}
			
		}
		return s;
	}
	public static string Decoder(this string str)
	{
		string s="";
		foreach(char c in str)
		{
			string s1="xyzXYZ";
			string s2="abcABC";
			for(int i=0; i<6;i++)
			{
				if(c==s2[i])
				{
					s+=s1[i];
				}
				

			}
			if(c!='a'&&c!='b'&&c!='c'&&c!='A'&&c!='B'&&c!='C')
			{
				s+=(char)(c-3);
			}
			
		}
		return s;
	}
}