int edad = 0;
bool isNumber = false;
Console.WriteLine("ingrese su nombre de usuario:");
var myusername = Console.ReadLine();

Console.WriteLine("ingrese su edad");
var myage = Console.ReadLine();
isNumber = (int.TryParse(myage, out edad));
while (!isNumber || (edad < 1 || edad > 150))
{
    if (!isNumber)
    {
        Console.WriteLine("el formato de edad es invalido..por favor ...");
    }
    if (edad < 1 || edad > 150)
    {
        Console.WriteLine("Elrango de la edad........");
    }
    myage = Console.ReadLine();
    isNumber = (int.TryParse(myage, out edad));
}


if (edad >= 18)
{
    Console.WriteLine($"el usuario {myusername} es mayor de edad");
}
else
{
    Console.WriteLine($"el usuario {myusername} no es mayor de edad");

}
Console.WriteLine("__________________________________________________");
Console.WriteLine("escoja un numero");
var montselect = Console.ReadLine();
var number = 12;
var monts = new List<string>()
{
    "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "julio" , "agosto", "septiembre ", "octubre","Noviembre", "Diciembre"
};
//monts.TakeWhile()
//var number = 7;
//var days = new List<string>()
//{
//    "Lunes", "Martes", "Miercoles", "Jueves","Viernes", "Sabado", "Domingo"
//};


//for (var i = 0; i < number; i++)
//{
//    Console.WriteLine(days[i]);
//}
