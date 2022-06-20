using System.Collections.Generic;

namespace FSM
{
    public abstract class Transition
    {
        protected StateMachine m_stateMachine;

        public Transition(StateMachine stateMachine)
        {
            m_stateMachine = stateMachine;
        }

        public abstract bool IsTriggerd();
        public abstract State GetTargetState();
        public abstract List<Act> GetActs();
    }
}