using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class StintRecord {
        public string PlayerId { get; private set; } = "";
        public long YearId { get; private set; } = 0;
        public long StintId { get; private set; } = 0;
        public string TeamId { get; private set; } = "";
        public string TeamName { get; private set; } = "";
        private DateTime? _stintStart;
        private DateTime? _stintEnd;
        public DateTime? StintStart {
            get {
                return _stintStart;
            }
            //season start & end must be inside the season year; thus, setter ignores the DateTime input's year component
            set {
                if (value != null) {
                    _stintStart = new DateTime((int)YearId, value.Value.Month, value.Value.Day);
                }
            }
        }
        public DateTime? StintEnd {
            get {
                return _stintEnd;
            }
            //season start & end must be inside the season year; thus, setter ignores the DateTime input's year component
            set {
                if (value != null) {
                    _stintEnd = new DateTime((int)YearId, value.Value.Month, value.Value.Day);
                }
            }
        }
        //calculated fields
        public int StintDuration { get; private set; } = 0;
        public decimal StintX { get; private set; } = 0; // proportion of season taken by this stint (stint duration / season duration)

        //*****
        //constructors
        //*****
        internal StintRecord(Stint stint) {
            PlayerId = stint.PlayerId;
            YearId = stint.YearId;
            StintId = stint.StintId;

            if (stint.TeamId != null) {
                TeamId = stint.TeamId;
                TeamName = Queries.GetTeamName(TeamId, YearId);
            }
            if (stint.StintStart != null) {
                StintStart = Helpers.StringToMonthDate(YearId, stint.StintStart) ?? null;
            }
            if (stint.StintEnd != null) {
                StintEnd = Helpers.StringToMonthDate(YearId, stint.StintEnd) ?? null;
            }

            CalcDuration();
        }

        //for creating fresh records that don't exist in database yet, so user can input dates
        internal StintRecord(string playerId, long yearId, long stintId, string teamId) {
            PlayerId = playerId;
            YearId = yearId;
            StintId = stintId;
            TeamId = teamId;
            TeamName = Queries.GetTeamName(TeamId, yearId);
        }

        //full-parameter constructor for creating StintRecord copies without having to re-query known data
        private StintRecord(string playerId, long yearId, long stintId, string teamId, string teamName,
            DateTime? stintStart, DateTime? stintEnd, int stintDuration, decimal stintX) {
            PlayerId = playerId;
            YearId = yearId;
            StintId = stintId;
            TeamId = teamId;
            TeamName = teamName;
            StintStart = stintStart;
            StintEnd = stintEnd;
            StintDuration = stintDuration;
            StintX = stintX;
        }

        //*****
        //Methods
        //*****

        //Calc stint duration
        internal void CalcDuration() {
            if (StintStart.HasValue && StintEnd.HasValue && StintStart < StintEnd) {
                TimeSpan interval = (DateTime)StintEnd - (DateTime)StintStart;
                StintDuration = interval.Days;
            }
        }

        //calc stint X (proportion of season taken by this stint)
        internal void CalcStintX(int seasonDuration) {
            if (StintDuration > 0 && seasonDuration > 0) {
                StintX = StintDuration / (decimal)seasonDuration;
            }
        }

        //copy object
        public StintRecord Copy() {
            return new StintRecord(PlayerId, YearId, StintId, TeamId, TeamName, StintStart, StintEnd, StintDuration, StintX);
        }

    } //end StintRecord class
} //end BaseballModel.Model namespace