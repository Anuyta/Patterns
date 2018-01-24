namespace BehavioralPatterns
{
    public abstract class Studying
    {
        protected abstract void Enter();

        protected abstract void Study();

        protected abstract void PassExams();

        protected abstract void GetAttestat();

        public void EducationProcess()
        {
            Enter();
            Study();
            PassExams();
            GetAttestat();
        }
    }
}
