using System.Collections;
using System.Collections.Generic;

namespace BehavioralPatterns
{
    class SchoolList : IEnumerable<int>
    {
        private List<School> schools = new List<School>();

        public void AddItem(School school)
        {
            schools.Add(school);
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var item in schools)
            {
                yield return item.Number;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
