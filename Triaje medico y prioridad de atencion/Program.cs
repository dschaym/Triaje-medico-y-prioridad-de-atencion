Console.WriteLine("TRIAJE MEDICO Y PRIORIDAD DE ATENCION");
Console.WriteLine("Tipo de atencion:");
Console.WriteLine("* 1. Emergencia");
Console.WriteLine("* 2. Consulta");
Console.WriteLine("* 3.Pediatria");
Console.WriteLine("* 4. Traumatologia");
Console.WriteLine("Ingrese el tipo de atencion:");
int tipoAtencion = int.Parse(Console.ReadLine());
Console.WriteLine("Edad del paciente:");
int edad = int.Parse(Console.ReadLine());
Console.WriteLine("Temperatura del paciente entre (30-45 °C):");
double temperatura = double.Parse(Console.ReadLine());
Console.WriteLine("Saturacion de oxigeno (80-100)");
int saturacionO = int.Parse(Console.ReadLine());
Console.WriteLine("Nivel de dolor (0-10)");
int nivelDolor = int.Parse(Console.ReadLine());
Console.WriteLine("Presion sistolica (50-200 mmHg)");
int presionS = int.Parse(Console.ReadLine());

if (tipoAtencion < 1 || tipoAtencion > 4)
{
    Console.WriteLine("Tipo de atencion no valido");
    return;
}
else  if (edad < 0 || edad > 120)
{
    Console.WriteLine("Edad no valida");
    return;
}
else if (temperatura < 30 || temperatura > 45)
{
    Console.WriteLine("Temperatura no valida");
    return;
}
else if (saturacionO < 80 || saturacionO > 100)
{
    Console.WriteLine("Saturacion de oxigeno no valida");
    return;
}
else if (nivelDolor < 0 || nivelDolor > 10)
{
    Console.WriteLine("Nivel de dolor no valido");
    return;
}
else if (presionS < 50 || presionS > 200)
{
    Console.WriteLine("Presion sistolica no valida");
    return;
}