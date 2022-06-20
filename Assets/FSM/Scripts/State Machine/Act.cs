using System;
using UnityEngine;

namespace FSM
{
    public abstract class Act
    {
        protected StateMachine m_stateMachine;

        public static Action Completed;

        public virtual void PlayAct()
        {
            Debug.Log($"{this} Act has been played!");
            Completed?.Invoke();
        }
    }
}