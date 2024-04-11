using UnityEngine;

public interface IGameState
{
    void OnEnterState();
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
    void OnEnterState(Ball? ball, GameObject? go);
    void OnUpdateState();
    void OnExitState();
}

public interface IShootState
{
    void OnEnterState();
    void OnUpdateState();
    void OnExitState();
}


