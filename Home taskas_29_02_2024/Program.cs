

// 2)  2 eded extension method yazirsiz. Biri emailin icinde @ isaresinin olub olmamasini yoxlamalidir. Digeri passwordun uzunluqunun 8den boyuk olub olmadigini yoxlamalidir.





using Home_taskas_29_02_2024.Extensions.UserExtensions;



string email = "Alimamedov@gmail.com";
bool isEmailAccess = email.CheckEmail();
Console.WriteLine(isEmailAccess);



string password = "mamedov987789_";
bool isPasswordAccess = password.CheckPasswordLength();
Console.WriteLine(isPasswordAccess);










//3) int arrayi ucun extention method yazirsiz. Hemin extention method arrayin elementlerinin hasilini tapsin.


int[] numbers = { 4, 27, 3, 9, 15, 24};
int myarray = numbers.MyArray();
Console.WriteLine(myarray);









// 4) CalculatorService adinda class yaradirsiz, hemin classin icinde Calculation metodunuz olur. Method 2 parametr qebul edir. 4 emeliyyati (+,-,*,/)hesablayan calculator olacaq.
// Reqemler ve operatorlar console-dan daxil edilmelidir. Uygun controller de olsun.


