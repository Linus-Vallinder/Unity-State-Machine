using System.Collections.Generic;

namespace FSM
{
    public abstract class State
    {
        protected StateMachine m_stateMachine;

        public State(StateMachine stateMachine)
        {
            m_stateMachine = stateMachine;
        }

        public abstract List<Act> GetEntryActs();

        public abstract List<Act> GetActs();

        public abstract List<Act> GetExitActs();

        public abstract List<Transition> GetTransitions();
    }
}