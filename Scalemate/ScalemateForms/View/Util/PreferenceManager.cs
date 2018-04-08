using ScalemateForms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScalemateForms.View.Util
{
    /// <summary>
    /// This is the class that will handle preferences amongst the view.
    /// </summary>
    public class PreferenceManager
    {
        /// <summary>
        /// Creates a new preference manager. Requires the existence of a 
        /// "assets\preferences.csv" file containing all stored preferences.
        /// </summary>
        public PreferenceManager()
        {
            DAL = new DataAccessLayer();
            Preferences = new Dictionary<string, string>();
            var rawPreferences = DAL.Load(DAL.GetPreferencesPath());
            foreach (string rawPreference in rawPreferences)
            {
                var fields = rawPreference.Trim().Split('\t');
                Preferences[fields[0]] = fields[1];
            }
        }

        /// <summary>
        /// Gets the current set language.
        /// </summary>
        /// <returns>The language code</returns>
        public string GetLanguage()
        {
            return Preferences["language"];
        }

        /// <summary>
        /// Stores the current preferences.
        /// </summary>
        public void Store()
        {
            DAL.Save(@"assets\preferences.csv", 
                     Preferences.Keys
                                .Select(k => $"{k}\t{Preferences[k]}")
                                .Aggregate("", (box, it) => $"{box}{it}\n"));
        }

        private DataAccessLayer DAL;
        public Dictionary<string, string> Preferences { get; private set; }
    }
}
