
using ejercicio05;
using System.Runtime.Intrinsics.X86;
//Property con init para fecha de nacimiento: Use init para que la fecha de nacimiento no pueda cambiarse despues de crear.

Console.WriteLine("=== FECHA DE NACIMIENTO ===");

// Crear objeto y asignar la fecha de nacimiento
Persona persona = new Persona("10/05/2008");
persona.Salida();

//Esto da error porque solo se puede poner una sola vez la fecha
persona.FechaNacimiento = "20/08/2010";

