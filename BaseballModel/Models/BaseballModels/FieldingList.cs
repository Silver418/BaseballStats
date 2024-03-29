﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class FieldingList {
        private List<FieldingRecord> list = new List<FieldingRecord>();

        public int Count { get; private set; }

        //**********
        //Constructors

        public FieldingList(IEnumerable<Fielding>? fielding = null, IEnumerable<FieldingOfsplit>? fieldingOfSplit = null,
            IEnumerable<FieldingOf>? fieldingOf = null) {
            //process data from FieldingOfSplit table
            if (fieldingOfSplit != null) {
                foreach (FieldingOfsplit record in fieldingOfSplit) {
                    list.Add(new FieldingRecord(record));
                }
            }

            //process data from FieldingOf split, with different logic depending on whether we also have FieldingOfSplit data
            if (fieldingOfSplit != null && fieldingOf != null) {
                foreach (FieldingOf lumpLine in fieldingOf) {
                    //see if matching records already exist in the Splits data
                    int count = (from record in list
                                 where record.PlayerId == lumpLine.PlayerId
                                 && record.YearId == lumpLine.YearId
                                 && record.Stint == lumpLine.Stint
                                 select record.Pos).Count();

                    //make non-detailed records if no detailed splits available
                    if (count == 0) {
                        if (lumpLine.Glf > 0) {
                            list.Add(new FieldingRecord(lumpLine, Position.LF));
                        }
                        if (lumpLine.Gcf > 0) {
                            list.Add(new FieldingRecord(lumpLine, Position.CF));
                        }
                        if (lumpLine.Grf > 0) {
                            list.Add(new FieldingRecord(lumpLine, Position.RF));
                        }
                    }
                } //end foreach for lump records

            }
            else if (fieldingOf != null) { //if outfield data only includes lump data (no splits), use this block
                foreach (FieldingOf record in fieldingOf) {
                    if (record.Glf > 0) {
                        list.Add(new FieldingRecord(record, Position.LF));
                    }
                    if (record.Gcf > 0) {
                        list.Add(new FieldingRecord(record, Position.CF));
                    }
                    if (record.Grf > 0) {
                        list.Add(new FieldingRecord(record, Position.RF));
                    }
                }

            }

            //process data from Fielding table
            if (fielding != null) {
                foreach (Fielding record in fielding) {
                    list.Add(new FieldingRecord(record));
                }
            }

            Count = list.Count;
        } //end 3-param constructor

        //**********

        //get list
        public List<FieldingRecord> GetResults() {
            return list;
        }

        //sort functions
        public void TeamSort() {
            list.Sort(new TeamFieldingComparer());
        }
        public void PlayerSort() {
            list.Sort(new PlayerFieldingComparer());
        }


        //nested comparer classes
        //comparer for use with multiple players' records from a single year
        private class TeamFieldingComparer : IComparer<FieldingRecord> {
            public int Compare(FieldingRecord? x, FieldingRecord? y) {
                PositionComparer positionComparer = new PositionComparer();
                int posCompare = positionComparer.Compare(x.Pos, y.Pos);

                if (posCompare == 0) {
                    if (x.G > y.G) { //if same position, test # games - more games first
                        return -1;
                    }
                    else if (x.G < y.G) {
                        return 1;
                    }
                    else return String.Compare(x.PlayerId, y.PlayerId); //if same # games played, test PlayerIds (alphabetical)
                }
                else {
                    return posCompare;
                }
            }
        } //end TeamFieldingComprarer class

        //comparer for use with a player's records from multiple years
        private class PlayerFieldingComparer : IComparer<FieldingRecord> {
            public int Compare(FieldingRecord? x, FieldingRecord? y) {
                if (x.YearId < y.YearId) {
                    return -1;
                }
                else if (x.YearId > y.YearId) {
                    return 1;
                }
                else if (x.Stint < y.Stint) {
                    return -1;
                }
                else if (x.Stint > y.Stint) {
                    return 1;
                }
                else {
                    PositionComparer positionComparer = new PositionComparer();
                    return positionComparer.Compare(x.Pos, y.Pos);
                }
            } //end Compare method
        } //end PlayerFieldingComparer class
    }
}
