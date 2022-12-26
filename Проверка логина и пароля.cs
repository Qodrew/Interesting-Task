/ Проверка логина и пароля при вводе

string logUser = "Qantrop";
string passUser = "123456As";
string messageOutLogPass = "", messageEntetYes = "Добро пожаловать!", messageEntetNo = "Вход отклонен!";

Console.Write("Введите логин: ");
string loginUserIn = Console.ReadLine();

if (loginUserIn.Length < 6) messageOutLogPass = "Введен логин недопустимой длины" + messageEntetNo;
else if (loginUserIn != logUser) messageOutLogPass = "Неверный логин!" + messageEntetNo;
else {
    Console.Write("Введите пароль: ");
    string passUserIn = Console.ReadLine();
    messageOutLogPass = (passUserIn == passUser) ? messageEntetYes : "Неверный пароль!" + messageEntetNo;
}

Console.WriteLine(messageOutLogPass);
Console.ReadKey();
