using UnityEngine;

namespace FSM
{
    public abstract class StateMachine<T> : MonoBehaviour
    {
        protected State<T> _currentState;

        #region Unity Methods

        private void Update()
        {
            if (_currentState == null) return;
            _currentState.StateUpdateLogic();
        }

        private void LateUpdate()
        {
            if (_currentState == null) return;
            _currentState.StateUpdatePhysics();
        }

        #endregion Unity Methods

        public void SetState(State<T> state)
        {
            if (_currentState != null)
            {
                _currentState.Cancel();
            }

            _currentState = state;
            _currentState.Execute();
        }
    }
}