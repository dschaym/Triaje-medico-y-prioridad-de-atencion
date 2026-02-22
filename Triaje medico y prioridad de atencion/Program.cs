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

int prioridad = 3;
switch (tipoAtencion)
{
    case 1: // Emergencia
        if (saturacionO < 90)
        {
            prioridad = 1;
        }
        else
        {
            if (presionS < 90)
                prioridad = 1;
            else
            {
                if (nivelDolor >= 7)
                    prioridad = 2;
                else
                    prioridad = 3;
            }
        }
        break;
    case 2: // Consulta
        if (edad > 65 || edad < 5)
        {
            prioridad = 2;
        }
        else
            prioridad = 3;
        break;
    case 3: // Pediatria
        if (edad < 12)
        {
            if (temperatura >= 39|| nivelDolor >= 5)
            {
                prioridad = 2;
                if (edad < 2 || saturacionO < 92)
                    prioridad = 1;

            }
            else if (temperatura >= 37.5 || nivelDolor >= 3)
                prioridad = 2;
            else
                prioridad = 3;
        }
        else
            if (edad >= 12 && edad <= 17)
            {
                if (temperatura >= 38 || nivelDolor >= 5)
                {
                    prioridad = 2;
                    if (saturacionO < 92)
                        prioridad = 1;
                }
                else if (temperatura >= 37.5 || nivelDolor >= 3)
                    prioridad = 2;
                else
                    prioridad = 3;
            }
            else
                prioridad = 2;
        break;
    case 4: // Traumatologia
        if (nivelDolor >= 7)
        {
            prioridad = 1;
        }
        else if (nivelDolor >= 4)
            prioridad = 2;
        else
            prioridad = 3;
        break;
}

string acion;
if (prioridad == 1)
    acion = "Reanimacion inmediata";
else if (prioridad == 2)
    acion = "Observacion";
else
    acion = "Consulta general";

string nombreTipo;
if (tipoAtencion == 1)
    nombreTipo = "Emergencia";
else if (tipoAtencion == 2)
    nombreTipo = "Consulta";
else if (tipoAtencion == 3)
    nombreTipo = "Pediatria";
else
    nombreTipo = "Traumatologia";

Console.WriteLine("RESULTADOS DEL TRIAJE MEDICO");
Console.WriteLine($"Tipo de atencion: {nombreTipo}");
Console.WriteLine($"Prioridad de atencion: {prioridad}");
Console.WriteLine($"Accion a tomar: {acion}");