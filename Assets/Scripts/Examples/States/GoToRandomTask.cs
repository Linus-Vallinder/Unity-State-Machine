namespace FSM.Examples
{
    public class GoToRandomTask : State<Agent>
    {
        public GoToRandomTask(Agent stateMachine) : base(stateMachine)
        {
        }

        public override void Execute()
        {
            //Select a random task
        }
    }
}