using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class FieldingOfSplitList {
        private List<FieldingOfSplitRecord> list = new List<FieldingOfSplitRecord>();

        public int Count { get; private set; }

        //constructor
        public FieldingOfSplitList(IEnumerable<FieldingOfsplit> results) {
            foreach (FieldingOfsplit record in results) {
                list.Add(new FieldingOfSplitRecord(record));
            }

            Count = list.Count;
        }

        //get list copy
        public List<FieldingOfSplitRecord> GetResults() {
            return new List<FieldingOfSplitRecord>(list);
        }

        //calculate Left, Center, and Right field games played for a given year+stint
        public (long left, long center, long right) GetOutfieldGames(long year, long stint) {
            long left = 0, center = 0, right = 0;
            foreach (FieldingOfSplitRecord record in list) {
                if (year == record.YearId && stint == record.Stint) {
                    switch (record.Pos) {
                        case "LF":
                            left += record.G;
                            break;
                        case "CF":
                            center += record.G;
                            break;
                        case "RF":
                            right += record.G;
                            break;
                        default:
                            break;
                    } //end switch
                } //end if (year & stint match)
            } //end foreach through records
            return (left, center, right);
        } //end GetOutfieldGames
    }
}
