using UnityEngine.AI;

namespace FSM.Examples
{
    public class Agent : StateMachine<Agent>
    {
        private NavMeshAgent _navMeshAgent;

        #region Unity Methods

        private void Awake()
        {
            _navMeshAgent = GetComponent<NavMeshAgent>();
        }

        private void Start()
        {
            SetState(new GoToRandomTask(this));
        }

        #endregion Unity Methods

        #region Actions

        public void GetRandomTask()
        {
            //return a task target
        }

        #endregion

        #region Booleans

        #endregion
    }
}