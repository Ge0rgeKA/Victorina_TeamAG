namespace Victorina_TeamAG.Core
{
    public class Victorina
    {
 
        public string VictorinaName { get; set; }
        public List <string> Questions { get; set; }
        public List <string> Answers { get; set; }
        public List<int> IndexOfRightAnswer { get; set; }

        public Victorina(string victorinaName, List <string> questions, List<string> answers, List<int> indexOfRightAnswer)
        {
            VictorinaName = victorinaName;
            Questions = questions;
            Answers = answers;
            IndexOfRightAnswer = indexOfRightAnswer;
        }
    }
}