//Sobrecarga de metodo Saludar: Cree 3 versiones: sin parametros, con nombre, con nombre y edad.

using ejercicio01;

Console.WriteLine("=== SOBRECARGA DE SALUDOS ===");

//Salida
Sobrecarga saludo = new Sobrecarga();
saludo.Saludar();
saludo.Saludar("Juan Porras");
saludo.Saludar("Juan Porras", 18);


