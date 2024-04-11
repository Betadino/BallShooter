using UnityEngine;
using UnityEditor.UIElements;

public class RunningState : IGameState
{
    public void OnEnterState()
    {
        
        Subject.GameStart();
    }
    public void OnUpdateState()
    {}
    public void OnExitState()
    {}
}

public class EndedState : IGameState
{
    public void OnEnterState()
    {
        Subject.GameOver();
    }
    public void OnUpdateState()
    {}
    public void OnExitState()
    {}
}