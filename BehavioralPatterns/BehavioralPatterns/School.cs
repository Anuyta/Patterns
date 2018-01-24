namespace BehavioralPatterns
{
    class School : Studying
    {
        protected override void Enter()
        {
            System.Console.WriteLine("I entered in school");
        }

        protected override void Study()
        {
            System.Console.WriteLine("I'm studying in school");
        }

        protected override void PassExams()
        {
            System.Console.WriteLine("I passed exam in school");
        }

        protected override void GetAttestat()
        {
            System.Console.WriteLine("I got attestat from school");
        }
    }
}
