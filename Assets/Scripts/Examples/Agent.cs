using UnityEngine.AI;
using UnityEngine;

namespace FSM.Examples
{
    public class Agent : StateMachine<Agent>
    {
        public Task CurrentTask
        {
            get { return _currentTask; }
            set { _currentTask = value; }
        }

        private Task _currentTask;

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

        public Task GetRandomTask()
        {
            Task[] tasks = FindObjectsOfType<Task>();
            var randomTaskIndex = Mathf.RoundToInt(Random.Range(0, tasks.Length - 1));
            return tasks[randomTaskIndex];
        }

        public void SetAgentDestination(Vector3 position)
        {
            _navMeshAgent.SetDestination(position);
        }

        #endregion

        #region Booleans

        #endregion
    }
}