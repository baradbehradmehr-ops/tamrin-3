// in tamrin mrbvt bh bharad mhar ast v yek add ra baraks miknd 
// mslan 4321 bh 1234 tbdyl miknd 
// mn dar akhr barname bhsvrt tozyh yek rah ke kamtar mtghyr miznd ghrar dadm
Console.Clear();
Console.Write("number chear rghmi: ");
var number=Convert.ToInt32(Console.ReadLine());
var rghm4=number%10;
var rghm3=number%100/10;
var rghm2=number%1000/100;
var rghm1=number%10000/1000;
Console.Write($"baraks add shoma: {rghm4}{rghm3}{rghm2}{rghm1}");
// Console.Write(@$"omacos add shma :
//{number%10}{number%100/10}{number%1000/100}{number%10000/1000}");