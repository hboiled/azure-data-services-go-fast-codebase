namespace WebApplication.Models.Customisations.WizardReference
{
    public class CheckBoxOption<U> where U : System.Enum
    {
        public U Option { get; set; }
        public bool IsSelected { get; set; }

    }
}