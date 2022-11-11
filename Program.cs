using DesafioPOO.Models;

Iphone iphone14 = new Iphone("61996060064", "Iphone 14", "ABCD123456",6);
Nokia nokiaLumia = new Nokia("61996060027","Nokia Lumia", "ABCD123457", 12);

nokiaLumia.Ligar();
iphone14.ReceberLigacao();
iphone14.Ligar();
nokiaLumia.ReceberLigacao();

iphone14.InstalarAplicativo("Sleep Cycle");
nokiaLumia.InstalarAplicativo("Sleep Cycle");