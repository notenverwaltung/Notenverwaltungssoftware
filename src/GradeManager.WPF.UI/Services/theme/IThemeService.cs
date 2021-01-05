namespace GradeManager.WPF.UI.Services
{
    public interface IThemeService
    {
        void UpdatePrimary(System.Windows.Media.Color primaryColor);

        void UpdateSecondary(System.Windows.Media.Color secondaryColor);

        void UpdateTheme(MaterialDesignThemes.Wpf.BaseTheme themeMode);
    }
}