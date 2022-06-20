using System.Collections.Generic;
using UnityEngine;

namespace FSM
{
    public abstract class StateMachine : MonoBehaviour
    {
        protected State m_initialState;

        private State m_currentState;

        #region Unity Methods

        private void Start()
        {
            m_currentState = m_initialState;
        }

        private void Update()
        {
            List<Act> acts = Tick();

            foreach (Act act in acts)
            {
                act.PlayAct();
            }
        }

        #endregion Unity Methods

        public List<Act> Tick()
        {
            Transition triggerdTransition = null;

            foreach (Transition transition in m_currentState.GetTransitions())
            {
                if (transition.IsTriggerd())
                {
                    triggerdTransition = transition;
                    break;
                }
            }

            if (triggerdTransition != null)
            {
                State target = triggerdTransition.GetTargetState();

                List<Act> acts = m_currentState.GetExitActs();
                acts.AddRange(triggerdTransition.GetActs());
                acts.AddRange(target.GetEntryActs());

                m_currentState = target;
                return acts;
            }
            else
            {
                return m_currentState.GetActs();
            }
        }
    }
}