using ExMillitaryElite.Enumerations;
using ExMillitaryElite.Exceptions;
using ExMillitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExMillitaryElite.Models
{
    public class Mission : IMission
    {
        public Mission(string codename, string state)
        {
            CodeName = codename;
            ParseState(state);
        }


        public string CodeName { get; private set; }

        public State State { get; private set; }

        public void CompleteMission()
        {
            if (State==State.Finished)
            {
                throw new InvalidMissionCompletionException();
            }
            State = State.Finished;
        }
        private void ParseState(string stateString)
        {
            State state;

            bool parsed = Enum.TryParse<State>(stateString, out state);

            if (!parsed)
            {
                throw new InvalidStateException();
            }
            State = state;
        }

        public override string ToString()
        {
            return $"Code Name: {CodeName} State: {State}";
        }
    }
}
