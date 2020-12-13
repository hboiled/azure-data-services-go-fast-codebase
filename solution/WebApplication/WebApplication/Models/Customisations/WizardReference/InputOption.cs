namespace WebApplication.Models.Customisations.WizardReference
{
    public class InputOption<U> where U : System.Enum
    {
        public U Option { get; set; }
        public bool IsSelected { get; set; }

    }
}