using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models.Customisations.WizardReference
{
    public enum DataBreachPlan
    {
        [Display(Name = "Robust Audit Trail")]
        RobustAuditTrail = 0,
        [Display(Name = "Crisis Management Policy")]
        CrisisManagementPolicy = 1,
        [Display(Name = "Notify Of Data Breach Process")]
        NotifyDataBreachProcess = 2,
        [Display(Name = "Trained Staff")]
        TrainedStaff = 3,
        [Display(Name = "Other")]
        Other = 4
    }

    public class DataBreachPlanOption
    {
        public DataBreachPlan Option { get; set; }
        public bool IsSelected { get; set; }
    }

    public class DataBreachPlanOptions
    {
        
        public List<DataBreachPlanOption> Options { get; set; } = new List<DataBreachPlanOption>();

        public DataBreachPlanOptions()
        {
            foreach (DataBreachPlan plan in Enum.GetValues(typeof(DataBreachPlan)))
            {
                Options.Add(new DataBreachPlanOption
                {
                    Option = plan,
                    IsSelected = false
                });
            }
        }
    }
}
