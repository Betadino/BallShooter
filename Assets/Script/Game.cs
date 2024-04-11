public class Game{
    private IGameState currentState;

    Player player;
    public void SetState(IGameState state)
    {
        if(currentState!=null)
        {
            currentState.OnExitState();
        }
        currentState=state;

        if(currentState!=null)
        {
            currentState.OnEnterState(player);
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