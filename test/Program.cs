Console.Write("Введите пятизначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        string str = number.ToString();
        bool isPalindrome = true;
        
        for (int i = 0; i < str.Length / 2; i++) {
            if (str[i] != str[str.Length - i - 1]) {
                isPalindrome = false;
                break;
            }
        }
        
        if (isPalindrome) {
            Console.WriteLine("Число является палиндромом.");
        } else {
            Console.WriteLine("Число не является палиндромом.");
        }