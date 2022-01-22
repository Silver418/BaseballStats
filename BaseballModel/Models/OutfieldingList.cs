using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class OutfieldingList {
        private List<OutfieldingRecord> list = new List<OutfieldingRecord>();

        public int Count { get; private set; }

        //constructor with only Splits
        public OutfieldingList(IEnumerable<FieldingOfsplit> results) {
            foreach (FieldingOfsplit record in results) {
                list.Add(new OutfieldingRecord(record));
            }

            Count = list.Count;
        }

        //constructor with only less-detailed OF records
        public OutfieldingList(IEnumerable<FieldingOf> results) {
            foreach (FieldingOf record in results) {
                if (record.Glf > 0) {
                    list.Add(new OutfieldingRecord(record, Position.LF));
                }
                if (record.Gcf > 0) {
                    list.Add(new OutfieldingRecord(record, Position.CF));
                }
                if (record.Grf > 0) {
                    list.Add(new OutfieldingRecord(record, Position.RF));
                }
            }
        }

        //constructor with both splits and lump records
        public OutfieldingList(IEnumerable<FieldingOfsplit> splits, IEnumerable<FieldingOf> lump)
            : this(splits) {
            foreach (FieldingOf lumpLine in lump) {
                //see if matching records already exist in the Splits data
                int count = (from record in list
                                            where record.PlayerId == lumpLine.PlayerId
                                            && record.YearId == lumpLine.YearId
                                            && record.Stint == lumpLine.Stint
                                            select record.Pos).Count();

                //make non-detailed records if no detailed records are found for that year/stint
                if (count == 0) {
                    if (lumpLine.Glf > 0) {
                        list.Add(new OutfieldingRecord(lumpLine, Position.LF));
                    }
                    if (lumpLine.Gcf > 0) {
                        list.Add(new OutfieldingRecord(lumpLine, Position.CF));
                    }
                    if (lumpLine.Grf > 0) {
                        list.Add(new OutfieldingRecord(lumpLine, Position.RF));
                    }
                }

                //sort list
                list = list.OrderBy(x => x.YearId).ThenBy(x => x.Stint).ToList();
            } //end foreach for lump records
        } //end constructor for splits + lump

        //get list copy
        public List<OutfieldingRecord> GetResults() {
            return new List<OutfieldingRecord>(list);
        }

    }
}
