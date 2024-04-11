using UnityEditor.UIElements;

public class RunningState : IGameState
{
    public void OnEnterState(Player player)
    {
        player.SetState(new AliveState());
    }
    public void OnUpdateState()
    {}
    public void OnExitState()
    {}
}

public class EndedState : IGameState
{
    public void OnEnterState(Player? player)
    {}
    public void OnUpdateState()
    {}
    public void OnExitState()
    {}
}