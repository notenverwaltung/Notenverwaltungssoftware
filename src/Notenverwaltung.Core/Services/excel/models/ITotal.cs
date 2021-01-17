namespace Notenverwaltung.Core.Services
{
    public interface ITotal
    {
        public int? Deutsch { get; set; }

        public int? Englisch { get; set; }

        public int? Ethik { get; set; }

        public int? Kunst { get; set; }

        public int? Mathe { get; set; }

        public int? Musik { get; set; }

        public double? MwS { get; set; }

        public int? Religion { get; set; }

        public int? Sachkunde { get; set; }

        public int? Sport { get; set; }

        public int? Werken { get; set; }
    }
}