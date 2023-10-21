namespace Victorina_TeamAG.Core
{
    public class Victorina
    {
        public string VictorinaName { get; set; }
        public List <string> Questions { get; set; }

        public Victorina(string _victorinaName, List <string> _questions)
        {
            VictorinaName = _victorinaName;
            Questions = _questions;
        }
    }
}