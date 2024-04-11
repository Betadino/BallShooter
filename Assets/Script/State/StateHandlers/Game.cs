public class Game{
    private IGameState currGameState;
    
    
    public void SetState(IGameState state)
    {
        if(currGameState!=null)
        {
            currGameState.OnExitState();
        }
        currGameState=state;

        if(currGameState!=null)
        {
            currGameState.OnEnterState();
        }
    }

    public void Update()
    {
        if(currGameState!=null)
        {
            currGameState.OnUpdateState();
        }
    }
}