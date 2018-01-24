using System.Collections;
using System.Collections.Generic;

namespace BehavioralPatterns
{
    class UniversityList : IEnumerable<string>
    {
        private List<University> universities = new List<University>();

        public void AddItem(University university)
        {
            universities.Add(university);
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach (var item in universities)
            {
                yield return item.Name;
            }
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
