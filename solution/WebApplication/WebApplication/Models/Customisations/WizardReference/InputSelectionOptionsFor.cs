using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models.Customisations.WizardReference
{
  
    public class InputSelectionOptionsFor<T> where T : System.Enum
    {
        public List<InputOption<T>> Options { get; set; } = new List<InputOption<T>>();

        public InputSelectionOptionsFor()
        {
            foreach (T option in Enum.GetValues(typeof(T)))
            {
                Options.Add(new InputOption<T>
                {
                    Option = option,
                    IsSelected = false
                });
            }
        }

        public string TemplateName
        {
            get
            {                
                var genericType = typeof(T).Name;
                return $"EditorFor{genericType}";
            }
        }

    }
}
