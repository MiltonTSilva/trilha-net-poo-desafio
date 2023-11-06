using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia  = new Nokia(numero: "912345678",modelo:"Nokia C01 Plus",imei:"350845555897085",memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine(Environment.NewLine);

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone  = new Iphone(numero: "987654321",modelo:"Iphone 15 PRO",imei:"53808888579508",memoria:128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");