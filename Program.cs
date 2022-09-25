using DesafioPOO.Models;

Console.WriteLine("Celular Nokia");
Nokia nokia = new Nokia(numero: "220532331", modelo: "NOKIA 5.3", imei: "NK007", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Celular Iphone");
Iphone iphone = new Iphone(numero: "789983889", modelo: "Iphone 14", imei: "365888472", memoria: 240);
iphone.Ligar();
iphone.InstalarAplicativo("Twitter");
