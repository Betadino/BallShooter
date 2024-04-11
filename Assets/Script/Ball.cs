public class Ball{
    private IBallState currentState;

    public void SetState(IBallState state)
    {
        if(currentState!=null)
        {
            currentState.OnExitState();
        }
        currentState=state;

        if(currentState!=null)
        {
            currentState.OnEnterState();
        }
    }

    public void Update()
    {
        if(currentState!=null)
        {
            currentState.OnUpdateState();
        }
    }
}