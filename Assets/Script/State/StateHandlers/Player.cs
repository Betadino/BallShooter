public class Player{
    private IPlayerState currentState;

    public void SetState(IPlayerState state)
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