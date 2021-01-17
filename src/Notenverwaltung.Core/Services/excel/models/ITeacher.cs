namespace Notenverwaltung.Core.Services
{
    public interface ITeacher
    {
        public string Anrede { get; set; }

        public string Fach { get; set; }

        public bool Klassenleiter { get; set; }

        public string Kuerzel { get; set; }
    }
}