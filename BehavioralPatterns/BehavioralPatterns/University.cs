namespace BehavioralPatterns
{
    class University : Studying
    {
        protected override void Enter()
        {
            System.Console.WriteLine("I entered in university");
        }

        protected override void Study()
        {
            System.Console.WriteLine("I'm studying in university");
        }

        protected override void PassExams()
        {
            System.Console.WriteLine("I passed exam in university");
        }

        protected override void GetAttestat()
        {
            System.Console.WriteLine("I got attestat from university");
        }
    }
}
