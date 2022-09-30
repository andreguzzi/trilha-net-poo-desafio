using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia(numero: "123456789", modelo: "C20", imei: "50010020055", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsaap");

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone(numero: "123456789", modelo: "Iphone8", imei: "300700800100", memoria: 512);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
