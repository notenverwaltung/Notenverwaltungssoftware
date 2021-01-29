namespace Notenverwaltung.Core.Services
{
    public interface ITotal
    {
        public double? Deutsch { get; set; }

        public double? Englisch { get; set; }

        public double? Ethik { get; set; }

        public double? Kunst { get; set; }

        public double? Mathe { get; set; }

        public double? Musik { get; set; }

        public double? MwS { get; set; }

        public double? Religion { get; set; }

        public double? Sachkunde { get; set; }

        public double? Sport { get; set; }

        public double? Werken { get; set; }
    }
}