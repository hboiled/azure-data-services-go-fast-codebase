using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models.Customisations.WizardReference
{
  
    public class CheckBoxOptionsFor<T> where T : System.Enum
    {
        public List<CheckBoxOption<T>> Options { get; set; } = new List<CheckBoxOption<T>>();

        public CheckBoxOptionsFor()
        {
            foreach (T option in Enum.GetValues(typeof(T)))
            {
                Options.Add(new CheckBoxOption<T>
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
