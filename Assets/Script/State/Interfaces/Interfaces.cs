public interface IGameState
{
    
    void OnEnterState(Player? player);
    void OnUpdateState();
    void OnExitState();
}

public interface IPlayerState
{
    void OnEnterState();
    void OnUpdateState();
    void OnExitState();
}

public interface IUIState
{
    void OnEnterState();
    void OnUpdateState();
    void OnExitState();
}

public interface IBallState
{
    void OnEnterState();
    void OnUpdateState();
    void OnExitState();
}

public interface IShootState
{
    void OnEnterState();
    void OnUpdateState();
    void OnExitState();
}


