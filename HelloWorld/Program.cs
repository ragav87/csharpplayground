using HelloWorld.Services;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, my first program!");
Console.WriteLine("Hello, my second program!");

var calc = new Calculator();
int result = calc.Add(5, 7);
Console.WriteLine($"5 + 7 = {result}");

// Brutto Netto Rechner
Console.WriteLine("\n--- Brutto Netto Rechner ---");
Console.Write("Geben Sie Ihr Bruttogehalt ein (z.B. 3000): ");
double brutto = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Wählen Sie Ihre Steuerklasse (1, 3, 4, 5): ");
int steuerklasse = int.Parse(Console.ReadLine() ?? "1");

Console.Write("Kirchensteuerpflichtig? (ja/nein): ");
bool kirchensteuer = (Console.ReadLine()?.Trim().ToLower() == "ja");

double netto = BruttoNettoRechner.BerechneNetto(brutto, steuerklasse, kirchensteuer);
Console.WriteLine($"Ihr Nettogehalt beträgt: {netto:F2} Euro");

// Pension Plan Selector
Console.WriteLine("\n--- Pension Plan Selector ---");
Console.Write("Bitte geben Sie Ihr Alter ein: ");
int age = int.Parse(Console.ReadLine() ?? "0");
string plan = PensionPlanSelector.SelectPlan(age);
Console.WriteLine($"Empfohlener Rentenplan: {plan}");

