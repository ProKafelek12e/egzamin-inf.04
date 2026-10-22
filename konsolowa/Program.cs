Random random = new Random();

string[] smallCharacters = ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"];
string[] bigCharacters = ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"];
string[] specificCharacters = ["ą", "ę", "ł", "ń", "ó", "ś", "ż", "ź", "Ą", "Ę", "Ł", "Ń", "Ó", "Ś", "Ż", "Ź"];
int[] digits = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
string[] specialCharacters = ["!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "+"];

//********************************************
// nazwa funkcji: generatePassword
// opis funkcji: Generuje i zwraca string złożony z 12 losowych znaków (3 małe litery, 3 wielkie litery, 2 litery ze znakami diakretycznymi, 2 cyfry i 2 znaki specjalne) w losowej kolejności
// parametry: brak
// wartośc typ i opis: string - losowe 12 znaków
// autor:00000000000
//********************************************

string generatePassword()
{
    string password = "";

    for (int i = 0; i < 3; i++)
    {
        password = password.Insert(random.Next(0, password.Length), smallCharacters[random.Next(0, smallCharacters.Length)]);
    }
    for (int i = 0; i < 3; i++)
    {
        password = password.Insert(random.Next(0, password.Length), bigCharacters[random.Next(0, bigCharacters.Length)]);
    }
    for (int i = 0; i < 2; i++)
    {
        password = password.Insert(random.Next(0, password.Length), specificCharacters[random.Next(0, specificCharacters.Length)]);
    }
    for (int i = 0; i < 2; i++)
    {
        password = password.Insert(random.Next(0, password.Length), digits[random.Next(0, digits.Length)].ToString());
    }
    for (int i = 0; i < 2; i++)
    {
        password = password.Insert(random.Next(0, password.Length), specialCharacters[random.Next(0, specialCharacters.Length)].ToString());
    }
    return password;
}
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Hasło {i+1}. {generatePassword()}");    
}