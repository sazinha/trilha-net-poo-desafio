using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia(numero: "12345", modelo: "versão 1", imei: "111111", memoria: 30);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Iphone iphone = new Iphone(numero: "14566", modelo: "versão 2.0", imei: "22222", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
iphone.ReceberLigacao();

