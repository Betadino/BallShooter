public class AliveState : IPlayerState
{
    public void OnEnterState()
    {}
    public void OnUpdateState()
    {
        if (GameData.life == 0)
            {
                Subject.GameOver();
            }
    }
    public void OnExitState()
    {}
}

public class DeadState : IPlayerState
{
    public void OnEnterState()
    {}
    public void OnUpdateState()
    {}
    public void OnExitState()
    {}
}