using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel {
    public static class Queries {
        //******************************************************************************************
        //searches with user-parseable data
        //******************************************************************************************
        public static PersonSearchList PeopleByName(string nameFirst, string nameLast) {
            using (var db = new BaseballContext()) {
                //prepare search inputs
                nameFirst = nameFirst.Trim().ToLower();
                nameLast = nameLast.Trim().ToLower();

                IQueryable<Person> result = db.People;

                if (nameFirst.Length > 0) {
                    result = result.Where(record => record.NameFirst.ToLower().Contains(nameFirst)
                            || record.NameGiven.ToLower().Contains(nameFirst));
                }

                if (nameLast.Length > 0) {
                    result = result.Where(record => record.NameLast.ToLower().Contains(nameLast));
                }

                return new PersonSearchList(result);
            }
        }

        public static TeamYearSearchList TeamYearByName(string teamName, string lgAbbr, long yearId) {
            using (var db = new BaseballContext()) {
                //prepare search inputs
                teamName = teamName.Trim().ToLower();
                lgAbbr = lgAbbr.Trim().ToLower();

                IQueryable<Team> result = db.Teams;

                if (teamName.Length > 0) {
                    result = result.Where(record => record.Name.ToLower().Contains(teamName));
                }
                if (lgAbbr.Length > 0) {
                    result = result.Where(record => record.LgId.ToLower().Contains(lgAbbr));
                }
                if (yearId > 0) {
                    result = result.Where(record => record.YearId == yearId);
                }

                return new TeamYearSearchList(result);
            }
        }

        //******************************************************************************************
        //searches with IDs etc.
        //******************************************************************************************
        public static PersonSearchRecord PersonByID(string id) {
            using (var db = new BaseballContext()) {
                var player =
                    (from person in db.People
                     where person.PlayerId == id
                     select person).FirstOrDefault();
                if (player != null)
                    return new PersonSearchRecord(player);
                return null;
            }
        }

        public static TeamYearSearchRecord TeamYearByID(string teamId, string lgAbbr, long yearId) {
            using (var db = new BaseballContext()) {
                var result =
                    (from team in db.Teams
                     where team.TeamId == teamId
                     && team.LgId == lgAbbr
                     && team.YearId == yearId
                     select team).FirstOrDefault();
                if (result != null)
                    return new TeamYearSearchRecord(result);
                return null;
            }
        }

        public static BattingList BattingByID(string id) {
            using (var db = new BaseballContext()) {
                var batting =
                    from bat in db.Battings
                    where bat.PlayerId == id
                    orderby bat.YearId, bat.Stint
                    select bat;

                return new BattingList(batting);
            }
        }

        public static BattingList TeamBattingByID(string teamId, string lgAbbr, long yearId) {
            using (var db = new BaseballContext()) {
                var batting =
                    from bat in db.Battings
                    where bat.TeamId == teamId && bat.LgId == lgAbbr && bat.YearId == yearId
                    orderby bat.Ab descending, bat.G descending, bat.PlayerId ascending
                    select bat;

                return new BattingList(batting);
            }
        }

        public static PitchingList PitchingByID(string id) {
            using (var db = new BaseballContext()) {
                var pitching =
                    from pitch in db.Pitchings
                    where pitch.PlayerId == id
                    orderby pitch.YearId, pitch.Stint
                    select pitch;

                return new PitchingList(pitching);
            }
        }

        public static PitchingList TeamPitchingByID(string teamId, string lgAbbr, long yearId) {
            using (var db = new BaseballContext()) {
                var pitching =
                    from pitch in db.Pitchings
                    where pitch.TeamId == teamId && pitch.LgId == lgAbbr && pitch.YearId == yearId
                    orderby pitch.Ipouts descending, pitch.G descending, pitch.PlayerId ascending
                    select pitch;

                return new PitchingList(pitching);
            }
        }

        public static FieldingList FieldingByID(string id) {
            using (var db = new BaseballContext()) {
                var fielding =
                    from field in db.Fieldings
                    where field.PlayerId == id
                    select field;

                FieldingList myList = new FieldingList(fielding);
                myList.PlayerSort();

                return myList;
            }
        }

        public static FieldingList TeamFieldingByID(string teamId, string lgAbbr, long yearId) {
            using (var db = new BaseballContext()) {
                var fielding =
                    from field in db.Fieldings
                    where field.TeamId == teamId && field.LgId == lgAbbr && field.YearId == yearId
                    select field;

                FieldingList myList = new FieldingList(fielding);
                myList.TeamSort();

                return myList;
            }
        }

        public static FieldingList OutfieldingByID(string id) {
            using (var db = new BaseballContext()) {
                var outfieldingSplits =
                    from outfield in db.FieldingOfsplits
                    where outfield.PlayerId == id
                    select outfield;

                var outfieldingLump =
                    from outfield in db.FieldingOfs
                    where outfield.PlayerId == id
                    select outfield;

                FieldingList result = new FieldingList(fieldingOfSplit: outfieldingSplits, fieldingOf: outfieldingLump);
                result.PlayerSort();
                return result;
            }
        }

        public static FieldingList TeamOutfieldingByID(string teamId, string lgAbbr, long yearId) {
            using (var db = new BaseballContext()) {
                var outfieldingSplits =
                    from outfield in db.FieldingOfsplits
                    where outfield.TeamId == teamId && outfield.LgId == lgAbbr && outfield.YearId == yearId
                    orderby outfield.Pos ascending, outfield.G descending, outfield.PlayerId ascending
                    select outfield;

                if (outfieldingSplits.Any()) {
                    FieldingList splitResult = new FieldingList(fieldingOfSplit: outfieldingSplits);
                    splitResult.TeamSort();
                    return splitResult;
                }
                else {
                    var players =
                        from p in db.Fieldings
                        where p.TeamId == teamId && p.LgId == lgAbbr && p.YearId == yearId
                        select new { p.PlayerId, p.YearId, p.Stint };

                    var outfieldingLump =
                        from outfield in db.FieldingOfs
                        join p in players on new { outfield.PlayerId, outfield.YearId, outfield.Stint }
                        equals new { p.PlayerId, p.YearId, p.Stint }
                        select outfield;

                    FieldingList lumpResult = new FieldingList(fieldingOf: outfieldingLump);
                    lumpResult.TeamSort();
                    return lumpResult;
                }
            }
        }

        public static FieldingOfRecord GetOutfieldingRecord(string playerId, long yearId, long stint) {
            using (var db = new BaseballContext()) {
                var outfieldQuery =
                    from OF in db.FieldingOfs
                    where OF.PlayerId == playerId && OF.Stint == stint && OF.YearId == yearId
                    select OF;

                var result = outfieldQuery.FirstOrDefault();
                if (result != null) {
                    return new FieldingOfRecord(result);
                }
                else {
                    return null;
                }
            }
        }


        public static (string first, string last) PlayerName(string playerId) {
            using (var db = new BaseballContext()) {
                string first = "";
                string last = "";

                var query =
                    from player in db.People
                    where player.PlayerId == playerId
                    select new { player.NameFirst, player.NameLast };
                var result = query.FirstOrDefault();

                first = result != null ? result.NameFirst : "";
                last = result != null ? result.NameLast : "";

                return (first, last);
            }
        }

        public static string PlayerBattingHand(string playerId) {
            using (var db = new BaseballContext()) {
                string? hand =
                    (from player in db.People
                     where player.PlayerId == playerId
                     select player.Bats).FirstOrDefault();

                if (hand != null)
                    return hand;

                else
                    return "";
            }
        }

        public static string PlayerThrowingHand(string playerId) {
            using (var db = new BaseballContext()) {
                string? hand =
                    (from player in db.People
                     where player.PlayerId == playerId
                     select player.Throws).FirstOrDefault();

                if (hand != null)
                    return hand;

                else
                    return "";
            }
        }


        //counts games played as an outfielder; returns a tuple with # of games for Left, Right, and Center field.
        //This method uses the detailed FieldingOfsplits table
        //Try the GetOutfieldingRecord (which uses the FieldingOfs table) before using this one
        public static (long left, long center, long right) GetOutfieldingSplitGames
            (string playerId, long yearId, long stint) {
            long left = 0, center = 0, right = 0;
            using (var db = new BaseballContext()) {
                var query = from splits in db.FieldingOfsplits
                            where splits.PlayerId == playerId && splits.YearId == yearId && splits.Stint == stint
                            select new { splits.Pos, splits.G };
                foreach (var splits in query) {
                    switch (splits.Pos) {
                        case "LF":
                            left += (long)splits.G;
                            break;
                        case "CF":
                            center += (long)splits.G;
                            break;
                        case "RF":
                            right += (long)splits.G;
                            break;
                        default:
                            break;
                    } //end switch
                }
            }
            return (left, center, right);
        }

        public static string GetTeamName(string id, long year) {
            using (var db = new BaseballContext()) {
                var teamQuery =
                    from team in db.Teams
                    where team.TeamId == id
                    && team.YearId == year
                    select team.Name;
                return teamQuery.FirstOrDefault() ?? "";
            }
        }

        public static (string teamId, string lgId) GetTeamLeague(string playerId, long yearId, long stint) {
            using (var db = new BaseballContext()) {
                var query = from batting in db.Battings
                            where batting.PlayerId == playerId && batting.YearId == yearId && batting.Stint == stint
                            select new { batting.TeamId, batting.LgId };
                var results = query.FirstOrDefault();

                string teamId = "";
                string lgId = "";

                if (results != null) {
                    teamId = results.TeamId;
                    lgId = results.LgId;
                }

                return (teamId, lgId);
            }
        }

        //**********
        //Season Transactions for transact.db
        //**********
        public static int SaveYear(DateTime start, DateTime end) {
            if (start.Year == end.Year && start < end) {
                using (var db = new TransContext()) {

                }
                return 0;
            }
            return 0;
        }
    }
}
