using GradeManager.WPF.UI.Services;
using MaterialDesignColors;
using MaterialDesignThemes.Wpf;
using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeManager.WPF.UI.ViewModels
{
    public class SettingsViewModel : GradeManager.Core.ViewModels.SettingsViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsViewModel" /> class.
        /// </summary>
        /// <param name="logProvider">The log provider.</param>
        /// <param name="navigationService">The navigation service.</param>
        public SettingsViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService, IThemeService themeService)
            : base(logProvider, navigationService)
        {
            this._themeService = themeService;

            BaseThemeValue = (MaterialDesignThemes.Wpf.BaseTheme)ColorSettings.Theme;
        }

        #region Methods

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        /// <returns>Initilisierung.</returns>
        public override Task Initialize()
        {
            return base.Initialize();
        }

        /// <summary>
        /// Prepares this instance. called after construction.
        /// </summary>
        public override void Prepare()
        {
            base.Prepare();
        }

        #endregion Methods

        #region Values

        private readonly IThemeService _themeService;
        private Array _baseTheme = Enum.GetValues(typeof(MaterialDesignThemes.Wpf.BaseTheme));

        private BaseTheme? _baseThemeValue;

        /// <summary>
        /// Gets or sets the apply accent command.
        /// </summary>
        /// <value>The apply accent command.</value>
        public IMvxCommand ApplyAccentCommand { get; set; }

        /// <summary>
        /// Gets or sets the apply primary command.
        /// </summary>
        /// <value>The apply primary command.</value>
        public IMvxCommand ApplyPrimaryCommand { get; set; }

        public List<MaterialDesignThemes.Wpf.BaseTheme> BaseThemeList
        {
            get => _baseTheme.OfType<MaterialDesignThemes.Wpf.BaseTheme>().ToList();
        }

        /// <summary>
        /// Gets or sets the base theme value.
        /// </summary>
        /// <value>The base theme value.</value>
        public MaterialDesignThemes.Wpf.BaseTheme? BaseThemeValue
        {
            get => _baseThemeValue;
            set
            {
                // nur wenn eine Änderung gewünscht ist
                if (_baseThemeValue != null)
                {
                    _themeService.UpdateTheme(value.Value);
                }

                SetProperty(ref _baseThemeValue, value);
            }
        }

        /// <summary>
        /// Gets the swatches.
        /// </summary>
        /// <value>The swatches.</value>
        public IEnumerable<Swatch> Swatches { get; }

        #endregion Values
    }
}