using UnityEngine;
public class BallAliveState : IBallState
{

    public void OnEnterState()
    {
    }
    public void OnUpdateState()
    {
    }
    public void OnExitState()
    {}
}

public class BallKillState : IBallState
{
    public void OnEnterState()
    {}
    public void OnUpdateState()
    {}
    public void OnExitState()
    {}
}

public class BallExplodeState : IBallState
{
    public void OnEnterState()
    {}
    public void OnUpdateState()
    {}
    public void OnExitState()
    {}
}