using UnityEngine;

namespace FSM.Examples
{
    public abstract class Task : MonoBehaviour
    {
        [Header("Task Position Options")]
        [SerializeField] private Vector3 _positionOffset;

        public bool IsCompleted
        {
            get { return _isCompleted; }
            set { _isCompleted = value; }
        }

        private bool _isCompleted = false;

        public Vector3 GetTaskPosition()
        {
            return transform.position + _positionOffset;
        }

    }
}