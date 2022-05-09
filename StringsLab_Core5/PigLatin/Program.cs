using System;

public class Program
{
	/*  1.==============================================================================================
		Design and implement a program that processes a string entered from the keyboard.  The application will
		- convert the string to upper and lowercase
		- reverse the string
		- count the number punctuation characters in the string
		- find the index of the first vowel in the string
		- divide the string up into "words"
		
		2.==============================================================================================
		Design and implement a program that converts a sentence entered by the user into pig latin.
		- version 1 - 	moves the first character to the end and adds ay
		- version 2 - 	words that start with vowels - add way to the end
						words that start with consonants - same as version 1
						
    */
	public static void Main()
	{
		Console.WriteLine("Please enter a word or phrase.  Press the ENTER key when you're done.");
		string input = Console.ReadLine();

		string[] vowelList = new string[] { "A", "a", "E", "e", "I", "i", "O", "o", "U", "u", "Y", "y" };

		// uppercase and lowercase
		string lower = input.ToLower();
		Console.WriteLine("Converted to lowercase: " + lower);
		string upper = input.ToUpper();
		Console.WriteLine("Converted to uppercase: " + upper);

		// iterate through a string with a foreach loop
		string reverse = "";
		foreach (char c in input)
			reverse = c + reverse;
		Console.WriteLine("In reverse: " + reverse);

		// use Char method.  Note that most of the Char methods are static - they get called on a CLASS
		// Math.pow is a static method.  gen.Next(..) gets called on a random OBJECT and is NOT static
		int pCount = 0;
		foreach (char c in input)
			if (Char.IsPunctuation(c))
				pCount++;
		Console.WriteLine("Puncutation count: " + pCount);

		// find the index of the first vowel in a string
		// see the method IsVowel below
		int vIndex = -1;
		// a string has a Length property  - just like an array
		for (int i = 0; i < input.Length && vIndex == -1; i++)
		{
			char c = input[i];
			if (IsVowel(c))
				vIndex = i;
		}
		Console.WriteLine("The index of the first vowel is: " + vIndex);

		// create an array of strings from a string.  Default delimiter is white space.
		string[] words = input.Split();
		foreach (string word in words)
			Console.WriteLine(word);

		string pig1 = PigLatin1(words[0]);
		Console.WriteLine("The word {0} in pig latin is: {1}", words[0], pig1);

		string pig2 = PigLatin2(words[0]);
		Console.WriteLine("The word {0} in pig latin is: {1}", words[0], pig2);

		char b = 'b';
		Console.WriteLine("Here's a character: " + b);
		int asciiOFb = (int)b;
		Console.WriteLine("Here's its ascii value: " + asciiOFb);
		char bPlus1 = (char)(asciiOFb + 1);
		Console.WriteLine("Here's the character after adding 10 to it's ascii value: " + bPlus1);
		char z = 'z';
		Console.WriteLine("Here's a character: " + z);
		int asciiOFz = (int)z;
		Console.WriteLine("Here's its ascii value: " + asciiOFz);
		char zPlus1 = (char)(asciiOFz + 1);
		Console.WriteLine("Here's the character after adding 1 to it's ascii value: " + zPlus1);
		Console.WriteLine("Darn!  z should be translated to a");
	}

	// I'll do this with you in a screen cast
	static bool IsVowel(char c)
	{
		return false;
	}

	static string PigLatin(string s)
	{
		string pig = s.Substring(1) + s[0] + "ay";
		return pig;
	}

	static string PigLatin1(string s)
	{
		string pig;
		if (IsVowel(s[0]))
			pig = s + "way";
		else
			pig = s.Substring(1) + s[0] + "ay";
		return pig;
	}

	static string PigLatin2(string s)
	{
		bool isUpper = false;
		string pig;
		if (Char.IsUpper(s[0]))
			isUpper = true;
		s = s.ToLower();
		int index = IndexOfFirstVowel(s);
		if (index == 0)
			pig = s + "way";
		else
			pig = s.Substring(index) + s.Substring(0, index) + "ay";
		if (isUpper == true)
			pig = pig.Substring(0, 1).ToUpper() + pig.Substring(1);

		return pig;
	}
	static int IndexOfFirstVowel(string s)
	{
		int index = -1;
		for (index = 0; index < s.Length; index++)
		{
			if (IsVowel(s[index]))
				return index;
		}
		return -1;

	}

	static bool VowelCheck(string[] vowels, string str)
	{
		bool isVowel = false;
		string[] split = str.Split();

			for (int i = 0; i < str.Length; i++)
			{
			if ((char[])split[i] = )
				isVowel = true;
			else
				isVowel = false;
			}
		return isVowel;
	}
}