using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballModel.Models {
    public class PersonSearchRecord {
        public string playerId { get; private set; }
        public string BirthDate { get; private set; } = "";
        public string DeathDate { get; private set; } = "";
        public string NameFirst { get; private set; } = "";
        public string NameLast { get; private set; } = "";
        public string NameGiven { get; private set; } = "";
        public string BatHand { get; private set; } = "";
        public string ThrowHand { get; private set; } = "";
        public string Debut { get; private set; } = "";
        public string FinalGame { get; private set; } = "";

        public PersonSearchRecord(Person person) {
            playerId = person.PlayerId;

            if (person.BirthYear > 0) {
                BirthDate = Helpers.StringyDate(person.BirthYear, person.BirthMonth, person.BirthDay);
            }

            if (person.DeathYear > 0) {
                DeathDate = Helpers.StringyDate(person.DeathYear, person.DeathMonth, person.DeathDay);
            }

            if (person.NameFirst != null) {
                NameFirst = person.NameFirst;
            }

            if (person.NameLast != null) {
                NameLast = person.NameLast;
            }

            if (person.NameGiven != null) {
                NameGiven = person.NameGiven;
            }

            if (person.Bats != null) {
                BatHand = person.Bats;
            }

            if (person.Throws != null) {
                ThrowHand = person.Throws;
            }

            if (person.Debut != null) {
                Debut = person.Debut;
            }

            if (person.FinalGame != null) {
                FinalGame = person.FinalGame;
            }
        }
    }
}