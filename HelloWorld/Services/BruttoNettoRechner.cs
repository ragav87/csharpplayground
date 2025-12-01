namespace HelloWorld.Services
{
    public class BruttoNettoRechner
    {
        public static double BerechneNetto(double brutto, int steuerklasse, bool kirchensteuer)
        {
            double steuerSatz = steuerklasse switch
            {
                1 => 0.20, // Steuerklasse 1: 20%
                3 => 0.10, // Steuerklasse 3: 10%
                4 => 0.18, // Steuerklasse 4: 18%
                5 => 0.30, // Steuerklasse 5: 30%
                _ => 0.20  // Default: 20%
            };

            double kirchensteuerSatz = kirchensteuer ? 0.09 : 0.0; // 9% Kirchensteuer

            double steuer = brutto * steuerSatz;
            double kirchensteuerBetrag = brutto * kirchensteuerSatz;
            double sozialabgaben = brutto * 0.20; // Pauschal 20% Sozialabgaben

            double netto = brutto - steuer - kirchensteuerBetrag - sozialabgaben;
            return netto;
        }
    }
}
