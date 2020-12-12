using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models.Customisations.WizardReference
{
    public enum Properties
    {
        Age = 0,
        Gender = 1,
        Quality = 2,
        [Display(Name = "Indigenous Stats")]
        IndigenousStats = 3,
        Location = 4,
        NA = 5
    }

    public class PropertyOption
    {
        public Properties Option { get; set; }
        public bool IsSelected { get; set; }
    }

    public class DatasetProperties
    {

        public List<PropertyOption> Options { get; set; } = new List<PropertyOption>();

        public DatasetProperties()
        {
            foreach (Properties prop in Enum.GetValues(typeof(Properties)))
            {
                Options.Add(new PropertyOption
                {
                    Option = prop,
                    IsSelected = false
                });
            }
        }
    }
}
