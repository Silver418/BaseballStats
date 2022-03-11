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
        public bool IgnoreStint { get; set; } = false;
        public bool PrimaryStint { get; set; } = false;

        //calculated fields
        public int StintDuration { get; private set; } = 0;
        public decimal StintX { get; internal set; } = 0; // proportion of season taken by this stint. Calculated in PersonStint, due to relying on too many externalities


        //Queried fields
        public string TeamName { get; private set; } = "";

        //*****
        //constructors
        //*****
        internal StintRecord(Stint stint) {
            //guaranteed inputs
            PlayerId = stint.PlayerId;
            YearId = stint.YearId;
            StintId = stint.StintId;
            IgnoreStint = stint.IgnoreStint;
            PrimaryStint = stint.PrimaryStint;            

            //nullable inputs
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
            if (stint.StintX != null) {
                StintX = (decimal)stint.StintX;
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

        //constructor for creating StintRecord copies without requerying/calculating known data
        private StintRecord(StintRecord stint) {
            PlayerId = stint.PlayerId;
            YearId = stint.YearId;
            StintId = stint.StintId;
            TeamId = stint.TeamId;
            TeamName = stint.TeamName;
            StintStart = stint.StintStart;
            StintEnd = stint.StintEnd;
            StintDuration = stint.StintDuration;
            IgnoreStint = stint.IgnoreStint;
            PrimaryStint = stint.PrimaryStint;
            StintX = stint.StintX;
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
        
        //copy object
        public StintRecord Copy() {
            return new StintRecord(this);
        }

    } //end StintRecord class
} //end BaseballModel.Model namespace