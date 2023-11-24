


//-------------------------------------------------------------Part 1.1

// ---using Reverse Function
string str = "SoftlogicLife";//string
string reversedArray = "";

char[] charArray = str.ToCharArray();//character array for reversing the string

Array.Reverse(charArray);//reversing the array

reversedArray = new string(charArray);

Console.WriteLine("Given String : " + str);

Console.WriteLine("Reversed String : "+reversedArray);


// ---without Reverse Function

int length = charArray.Length;

for (int i = 0; i < length / 2; i++)
{
    char temp = charArray[i];
    charArray[i] = charArray[length - 1 - i];
    charArray[length - 1 - i] = temp;
}

Console.WriteLine(charArray);




//--------------------------------------------------------------Part 1.2

// I have heard of bubble sorting somehow I can't remember the right way, So I try here with a normal way

int[] array = { 7, 6, 4, 3 };

//array.








//---------------------------------------------------------------Part 1.3

string vowels = "aeiou"; //vowels
char[] vowelsArray = vowels.ToCharArray();

int count = 0;

foreach (char chr in charArray)
{
    foreach (char chr2 in vowelsArray)
    {
        if (chr.ToString().ToLower() == chr2.ToString().ToLower())//comparing the characters in each character arrays in lowecase
        {
            count = count + 1;
        }
    }
}

Console.WriteLine("The vowel count in "+ str+" is :"+ count);










