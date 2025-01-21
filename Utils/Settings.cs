using System.ComponentModel;
using CsvQuery.PluginInfrastructure;
using Kbg.NppPluginNET;
using Kbg.NppPluginNET.PluginInfrastructure;
using NppDemo.Forms;

namespace NppDemo.Utils
{
    /// <summary>
    /// Manages application settings
    /// </summary>
    public class Settings : SettingsBase
    {
        /// <inheritdoc />
        public override void OnSettingsChanged()
        {
            base.OnSettingsChanged();
            Main.RestyleEverything();
            // make sure to check the HTML tag plugin menu item if the setting is currently true
            PluginBase.CheckMenuItem(Main.IdAutoSearchTag, auto_search_active_tag);
        }

        #region MISCELLANEOUS
        [Description("Specify one of these chars for each toolbar icon you want to show, in the order you want:\r\n" +
                    "('a' = about form, 's' = selection remembering form, 'h' = automatically close HTML tags)\r\n" +
                    "This setting will take effect the next time you start Notepad++.\r\n" +
                    "If you want there to be NO toolbar icons, enter a character that does not represent an icon; do NOT leave this field empty."),
            Category("Miscellaneous"), DefaultValue("ash")]
        public string toolbar_icons { get; set; }

        
        #endregion

        #region STYLING
        [Description("Use the same colors as the editor window for this plugin's forms?"),
            Category("Styling"), DefaultValue(true)]
        public bool use_npp_styling { get; set; }
        #endregion
        #region SinumerikPPProject
        [Description("Settings for Sinumerik++ Projects Root Folder."),
            Category("Sinumerik++ Project"), DefaultValue("")]        
        public string SinPPRootFolder { get; set; }

        [Description("Translate all on clicking the Translate Button"),
            Category("Sinumerik++ Project"), DefaultValue(false)]
        public bool TranslateAll { get; set; }

        [Description("Default working Language for Sinumerik Projects"),
            Category("Sinumerik++ Project"), DefaultValue("eng")]
        public string DefaultLanguage { get; set; }
        [Description("Automatically on Double Clicking on Search Keywords in the Sinumerik Online Help"),
            Category("Sinumerik++ Project"), DefaultValue(false)]
        public bool auto_search_active_tag { get; set; }

        #endregion

        /*
         * #region TESTING
        [Description("Ask before running tests, because the test can hijack the user's clipboard"),
            Category("Testing"), DefaultValue(AskUserWhetherToDoThing.ASK_BEFORE_DOING)]
        public AskUserWhetherToDoThing ask_before_testing { get; set; }
        #endregion
         */
    }
}
