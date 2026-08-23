//Override de metodo Describir: Clase base Vehículo con método virtual. Auto y Moto lo sobrescriben.

using ejercicio02;

Console.WriteLine("=== DESCRIPCION VEHICULO ===");

//Objetos para crear carro y moto
Vehiculo car1 = new Auto("ABC-123", "BMW", 2);
Vehiculo mot1 = new Moto("DEF-456", "Kawasaki", 998);

//Salida de datos 
car1.Describir();
mot1.Describir();