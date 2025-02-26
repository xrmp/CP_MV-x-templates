public class StateMachine
{
    private State currentState;

    private static StateMachine instance;
    public static StateMachine Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new StateMachine();
            }
            return instance;
        }
    }

    public void Initialize(State startingState)
    {
        currentState = startingState;
        currentState.Enter();
    }

    public void ChangeState(State newState)
    {
        currentState.Exit();
        currentState = newState;
        currentState.Enter();
    }

    public void Update()
    {
        currentState.Update();
    }
}