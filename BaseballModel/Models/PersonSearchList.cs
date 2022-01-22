using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class PersonSearchList {
        private List<PersonSearchRecord> list = new List<PersonSearchRecord>();
        public int Count { get; private set; }

        public PersonSearchList(IEnumerable<Person> results) {
            foreach (Person person in results) { 
                list.Add(new PersonSearchRecord(person));
            }

            Count = list.Count;
        }

        public List<PersonSearchRecord> getResults() {
            return new List<PersonSearchRecord>(list);
        }
    }
}
