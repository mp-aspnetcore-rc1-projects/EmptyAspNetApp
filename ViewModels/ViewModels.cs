using System.Collections.Generic;
using BasicAspApp.Models;

namespace BasicAspApp.ViewModels
{
    // Represents a view model for ComputerLanguage.Show action
    public struct ComputerLanguageShow
    {
        public ComputerLanguage ComputerLanguage;

        public IEnumerable<Snippet> Snippets;

        /// Create a view model for ComputerLanguage.Show action
        public ComputerLanguageShow(ComputerLanguage ComputerLanguage, IEnumerable<Snippet> Snippets)
        {
            this.ComputerLanguage = ComputerLanguage;
            this.Snippets = Snippets;
        }
    }
}