using UnityEngine;

public class Ball{
    private IBallState currentState;

    public void SetState(IBallState state, Ball ball, GameObject go)
    {
        if(currentState!=null)
        {
            currentState.OnExitState();
        }
        currentState=state;

        if(currentState!=null)
        {
            currentState.OnEnterState(ball, go);
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