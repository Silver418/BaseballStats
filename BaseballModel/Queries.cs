﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel {
    public static class Queries {
        #region QueriesFromUserEnteredData
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
        #endregion

        #region QueriesFromIDs
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

        public static AppearanceList TeamAppearancesByID(string teamId, string lgId, long yearId) {
            using (var db = new BaseballContext()) {
                var list =
                    from appearance in db.Appearances
                    where appearance.TeamId == teamId && appearance.LgId == lgId && appearance.YearId == yearId
                    orderby appearance.PlayerId ascending
                    select appearance;

                return new AppearanceList(list);
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

        public static FieldingList TeamFieldingByID(string teamId, string lgAbbr, long yearId,
            bool includeOutfieldDetails = false, bool includePitching = true) {
            using (var db = new BaseballContext()) {
                IQueryable<Fielding> fielding =
                    from field in db.Fieldings
                    where field.TeamId == teamId && field.LgId == lgAbbr && field.YearId == yearId
                    select field;
                
                if (!includePitching) { //remove pitching records if unwanted
                    fielding = fielding.Where(f => f.Pos != "P");
                }

                FieldingList myList;
                if (!includeOutfieldDetails) { //do not want detailed OF info
                    myList = new FieldingList(fielding);
                }
                else { //want detailed OF info
                    var outfieldingSplits =
                        from outfield in db.FieldingOfsplits
                        where outfield.TeamId == teamId && outfield.LgId == lgAbbr && outfield.YearId == yearId
                        orderby outfield.Pos ascending, outfield.G descending, outfield.PlayerId ascending
                        select outfield;

                    var players =
                        from p in db.Fieldings
                        where p.TeamId == teamId && p.LgId == lgAbbr && p.YearId == yearId
                        select new { p.PlayerId, p.YearId, p.Stint };

                    var outfieldingLump =
                        from outfield in db.FieldingOfs
                        join p in players on new { outfield.PlayerId, outfield.YearId, outfield.Stint }
                        equals new { p.PlayerId, p.YearId, p.Stint }
                        select outfield;

                    myList = new FieldingList(fielding, outfieldingSplits, outfieldingLump);
                }
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
                        (from p in db.Fieldings
                        where p.TeamId == teamId && p.LgId == lgAbbr && p.YearId == yearId
                        select new { p.PlayerId, p.YearId, p.Stint }).Distinct();

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

        //gets teams active in a given year, as a sorted dictionary of <TeamId, TeamName>
        public static SortedDictionary<string, string> GetTeams(long year) {
            using (var db = new BaseballContext()) {
                SortedDictionary<string, string> teams = new SortedDictionary<string, string>();

                var query =
                    (from team in db.Teams
                     where team.YearId == year
                     select team);

                foreach (var team in query) {
                    teams.Add(team.TeamId, team.Name ?? "");
                }

                return teams;
            }
        }
        #endregion

        #region SeasonTransactionQueries
        //**********
        //Season Transactions for transact.db
        //**********
        public static int SaveYear(DateTime start, DateTime end) {
            int updated = 0;
            if (start.Year == end.Year && start < end) {
                long year = start.Year;
                string startString = Helpers.MonthDateToString(start);
                string endString = Helpers.MonthDateToString(end);
                using (var db = new TransContext()) {

                    SeasonDate? existing = (from row in db.SeasonDates
                                            where row.YearId == year
                                            select row).FirstOrDefault();
                    if (existing != null) {//update record
                        existing.SeasonStart = startString;
                        existing.SeasonEnd = endString;
                    }
                    else { //create new record
                        SeasonDate update = new SeasonDate { YearId = year, SeasonStart = startString, SeasonEnd = endString };
                        db.SeasonDates.Add(update);
                    }
                    updated = db.SaveChanges();
                }
            }
            return updated;
        } //end SaveYear method

        public static SeasonDateList GetAllSeasons() {
            using (var db = new TransContext()) {
                var seasons = from season in db.SeasonDates
                              orderby season.YearId ascending
                              select season;
                return new SeasonDateList(seasons);
            }
        }

        public static SeasonDateRecord GetSeason(long year) {
            using (var db = new TransContext()) {
                var season = (from row in db.SeasonDates
                              where year == row.YearId
                              select row).FirstOrDefault();
                if (season != null) {
                    return new SeasonDateRecord(season);
                }
                else {
                    return null;
                }

            }
        }
        public static SeasonDateRecord GetSeason(int year) {
            return GetSeason((long)year);
        }

        public static int DeleteSeason(long year) {
            using (var db = new TransContext()) {
                //check for stint records matching this season; do not remove season if any exist
                bool stints = (from stint in db.Stints
                               where stint.YearId == year
                               select stint).Any();
                if (stints) return 0; //if any stints found, abandon deletion

                var deletion = (from row in db.SeasonDates
                                where row.YearId == year
                                select row).FirstOrDefault();
                if (deletion != null) {
                    db.SeasonDates.Remove(deletion);
                    return db.SaveChanges();
                }
            }
            return 0;
        }

        internal static List<PersonStint> GetPlayersWithStints(long year, DateTime seasonStart, DateTime seasonEnd, int seasonDuration) {
            using (var db = new BaseballContext()) {
                using (var trans = new TransContext()) {
                    List<PersonStint> finalList = new List<PersonStint>();
                    //list of players who already have stint records with filled-out dates & values
                    //this is necessary to grab select one-stint players the user entered partial-season dates for
                    List<string> playersWithExistingStints =
                        (from stint in trans.Stints
                         where stint.YearId == year
                         select stint.PlayerId).ToList();

                    //list of players from batting & fielding records who have 2+ stints
                    //this is necessary to grab players who do not have stint dates entered, but ought to
                    List<string> playersNeedingStints =
                        (from bat in db.Battings
                         where bat.YearId == year
                         select new { bat.PlayerId, bat.Stint })
                        .Union(from field in db.Fieldings
                               where field.YearId == year
                               select new { field.PlayerId, field.Stint })
                        .GroupBy(x => x.PlayerId).Where(x => x.Count() > 1).OrderBy(x => x.Key)
                        .Select(x => x.Key).ToList();
                    //1. Pulls players & stint numbers from batting & fielding tables, then unions them.
                    //2. Groups the new set by player ID
                    //3. Selects a list of PlayerIds for players(groups) with more than 1 stint
                    //This avoids a theoretical problem where the dataset is missing records for stint #2 of a multi-stint player,
                    //which would omit the player even if there was data for their later stints.

                    //I don't know if going the longer route was worth it.

                    //combine lists
                    List<string> combined = playersWithExistingStints.Union(playersNeedingStints).ToList();
                    combined.Sort();



                    foreach (string player in combined) {
                        finalList.Add(new PersonStint(player, year, seasonStart, seasonEnd, seasonDuration));
                    }

                    return finalList;
                }
            }
        }

        internal static List<PersonStint> GetPlayersWithStints(int year, DateTime seasonStart, DateTime seasonEnd, int seasonDuration) {
            return GetPlayersWithStints((long)year, seasonStart, seasonEnd, seasonDuration);
        }

        internal static List<StintRecord> GetPlayerStints(long yearId, string playerId) {
            using (var db = new BaseballContext()) {
                //Due to silliness in the baseball stats database schema, I have to account for the possibility of
                //batting & fielding records having the same playerId, YearId, and Stint #, but different TeamIds.
                //there should've just been a stint table to avoid duplicating info

                List<StintRecord> list = new List<StintRecord>();

                var stints =
                (from bat in db.Battings
                 where bat.YearId == yearId && bat.PlayerId == playerId
                 select new { bat.Stint, bat.TeamId })
                 .Union
                 (from field in db.Fieldings
                  where field.YearId == yearId && field.PlayerId == playerId
                  select new { field.Stint, field.TeamId })
                 .OrderBy(x => x.Stint).ThenBy(x => x.TeamId).ToList();


                foreach (var record in stints) {
                    using (var transDb = new TransContext()) {
                        Stint? stint =
                            (from s in transDb.Stints
                             where s.PlayerId == playerId && s.YearId == yearId && s.StintId == record.Stint
                             select s).FirstOrDefault();

                        if (stint != null) { //an existing record in the stint table is found: Use that one
                            list.Add(new StintRecord(stint));
                        }
                        else { //no existing record in database: check if a fresh record for this stint has already been created locally
                            //(this is necessary due to the possibility of the batting & fielding tables disagreeing about what team a player was on for a given stint,
                            //which would produce two fresh records for a single stint if not caught
                            bool recordExists =
                                (from localRecord in list
                                 where localRecord.StintId == record.Stint
                                 select localRecord).Any();

                            if (!recordExists) { //if no fresh record exists in the local list, create one & add
                                list.Add(new StintRecord(playerId, yearId, record.Stint, record.TeamId));
                            } //no action necessary if an existing record is found
                        }

                    } //end using TransContext
                } //end foreach
                return list;
            } //end using BaseballContext
        } //end GetPlayerStints method

        //get List<StintRecord> of players who only have one stint in a given season; pulls StintRecord if exists, or creates fresh record
        public static List<dynamic> GetSingleStintPlayers(long yearId) {
            using (BaseballContext db = new BaseballContext()) {
                //query List<string> of players we want to include in the single-player list
                var oneStintPlayers =
                    (from a in db.Appearances
                     where a.YearId == yearId
                     group a by a.PlayerId into player
                     where player.Count() == 1
                     orderby player.Key ascending
                     select new { player.First().PlayerId, player.First().TeamId }).ToList();

                using (TransContext trans = new TransContext()) {
                    var stintsInYear =
                        (from stint in trans.Stints
                         where stint.YearId == yearId
                         select stint);

                    var playerStints =
                        (from a in oneStintPlayers
                         join stint in stintsInYear
                         on a.PlayerId equals stint.PlayerId into gj
                         from substint in gj.DefaultIfEmpty()
                         select new { a, substint }).AsEnumerable().Cast<dynamic>().ToList();

                    return playerStints;
                } //end using trans context
            } //end using baseball context
        }

        //get a single StintRecord if it exists in transaction.db; 
        public static StintRecord GetStint(string playerId, long yearId, long stintId) {
            using (TransContext db = new TransContext()) {
                Stint? stint = (from s in db.Stints
                                where s.PlayerId == playerId
                                && s.YearId == yearId
                                && s.StintId == stintId
                                select s).FirstOrDefault();
                if (stint != null) {
                    return new StintRecord(stint);
                }
                else return null;
            }
        }

        //save changed Stint back to database
        internal static int UpdateStint(StintRecord record) {
            using (var db = new TransContext()) {
                Stint? stint =
                    (from s in db.Stints
                     where s.PlayerId == record.PlayerId
                     && s.YearId == record.YearId
                     && s.StintId == record.StintId
                     select s).FirstOrDefault();
                string startString = "";
                string endString = "";
                if (record.StintStart != null) {
                    startString = Helpers.MonthDateToString((DateTime)record.StintStart);
                }
                if (record.StintEnd != null) {
                    endString = Helpers.MonthDateToString((DateTime)record.StintEnd);
                }
                if (stint != null) { //update existing record
                    stint.StintStart = startString;
                    stint.StintEnd = endString;
                    stint.StintX = record.StintX;
                    stint.PrimaryStint = record.PrimaryStint;
                    stint.IgnoreStint = record.IgnoreStint;
                }
                else { //else create new record
                    Stint update = new Stint {
                        PlayerId = record.PlayerId,
                        YearId = record.YearId,
                        StintId = record.StintId,
                        TeamId = record.TeamId,
                        StintStart = startString,
                        StintEnd = endString,
                        StintX = record.StintX,
                        PrimaryStint = record.PrimaryStint,
                        IgnoreStint = record.IgnoreStint
                    };
                    db.Stints.Add(update);
                }
                return db.SaveChanges();
            }
        }

        internal static int DeleteStint(StintRecord record) {
            using (var db = new TransContext()) {
                var stint =
                    (from s in db.Stints
                     where s.PlayerId == record.PlayerId
                     && s.YearId == record.YearId
                     && s.StintId == record.StintId
                     select s);
                if (stint.Any()) {
                    db.Remove(stint.First());
                    return db.SaveChanges();
                }
                else {
                    return 0;
                }
            }
        }
        #endregion

    } //end Queries class
} //end BaseballModel namespace
