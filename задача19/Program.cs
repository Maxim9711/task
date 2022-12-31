bool isTextPalindrome(string text) {
    string chars = text;
    int leftSymbol = 0;
    int rightSymbol = chars.Length - 1;
    while (leftSymbol < rightSymbol) {
        if (chars[leftSymbol] != chars[rightSymbol])
            return false;

        do {
            leftSymbol++;
        } while (leftSymbol < rightSymbol && chars[leftSymbol] == ' ');

        do {
            rightSymbol--;
        } while (rightSymbol > leftSymbol && chars[rightSymbol] == ' ');
    }
    return true;
}


// See https://aka.ms/new-console-template for more information
Console.Write("Введите пятизначное число: ");
string num = Console.ReadLine();

if(isTextPalindrome(num))
    Console.WriteLine($"Число {num} является полиндромом.");
else
    Console.WriteLine($"Число {num} не является полиндромом.");
