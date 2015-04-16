namespace HelloWorld.ConsoleApplication
{
    public class Mitarbeiter
    {
        public const string Manager = "Manager";
        public const string Teamleiter = "Teamleiter";
        public const string Angestellte = "Angestellte";

        public string Name { get; set; }
        public string Verhältnis { get; set; }
        public decimal AktuellesGehalt { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}