using MaterialDesignThemes.Wpf;
using Notenverwaltung.WPF.UI.Services.theme;
using System.Windows.Media;

namespace Notenverwaltung.WPF.UI.Services
{
    public class ThemeService : IThemeService
    {
        private readonly PaletteHelper _paletteHelper = new PaletteHelper();

        public void UpdatePrimary(Color primaryColor)
        {
            _paletteHelper.ChangePrimaryColor(primaryColor);
        }

        public void UpdateSecondary(Color secondaryColor)
        {
            _paletteHelper.ChangePrimaryColor(secondaryColor);
        }

        public virtual void UpdateTheme(BaseTheme themeMode)
        {
            if (themeMode == (int)MaterialDesignThemes.Wpf.BaseTheme.Inherit)
            {
                themeMode = Theme.GetSystemTheme().Value;
            }

            var paletteHelper = new PaletteHelper();

            //Retrieve the app's existing theme
            ITheme theme = paletteHelper.GetTheme();

            switch (themeMode)
            {
                case BaseTheme.Inherit:
                    break;

                case BaseTheme.Light:
                    theme.SetBaseTheme(Theme.Light);
                    break;

                case BaseTheme.Dark:
                    theme.SetBaseTheme(Theme.Dark);
                    break;

                default:
                    break;
            }

            //Change the app's current theme
            paletteHelper.SetTheme(theme);
        }
    }
}