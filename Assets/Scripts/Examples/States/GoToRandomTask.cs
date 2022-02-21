namespace FSM.Examples
{
    public class GoToRandomTask : State<Agent>
    {
        public GoToRandomTask(Agent stateMachine) : base(stateMachine)
        {
        }

        public override void Execute()
        {
            var randomTask = stateMachine.GetRandomTask();
            stateMachine.CurrentTask = randomTask;

            var targetPosition = stateMachine.CurrentTask.GetTaskPosition();
            stateMachine.SetAgentDestination(targetPosition);
        }

        public override void StateUpdateLogic()
        {
            if (stateMachine.CurrentTask.IsCompleted)
            {
                stateMachine.SetState(new GoToRandomTask(stateMachine));
            }
        }
    }
}