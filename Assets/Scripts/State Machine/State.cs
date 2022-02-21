using UnityEngine;

namespace FSM
{
    public abstract class State<T>
    {
        protected T stateMachine;

        protected State(T stateMachine)
        {
            this.stateMachine = stateMachine;
        }

        public virtual void Execute()
        {
            //Code is called once during the Start Method of the state machine.
        }

        public virtual void StateUpdateLogic()
        {
            //Code is called every frame within the standard Update Method of the state machine.
        }

        public virtual void StateUpdatePhysics()
        {
            //Code is called every frame within the standard LateUpdate Method of the state machine
        }

        public virtual void Cancel()
        {
            //Code is called once during the SetState method the state machine uses to transition from state to state.
        }
    }
}