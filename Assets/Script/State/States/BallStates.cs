using Unity.VisualScripting;
using UnityEngine;
public class BallAliveState : IBallState
{

    Ball ball;
    GameObject go;
    float timer;
    public void OnEnterState(Ball _ball, GameObject? _go)
    {
        ball=_ball;
        go=_go;
        timer = 1.5f;
    }
    public void OnUpdateState()
    {
        timer -= Time.deltaTime;
        if (timer < 0){
            Subject.Explosion(ball, go);
        }
    }
    public void OnExitState()
    {}
}

public class BallKillState : IBallState
{
    public void OnEnterState(Ball? ball, GameObject go)
    {
       Object.Destroy(go); 
    }
    public void OnUpdateState()
    {}
    public void OnExitState()
    {
    }
}

public class BallExplodeState : IBallState
{
    public void OnEnterState(Ball? ball,GameObject go)
    {
        Subject.ChangeLives();
        if (GameData.life == 0)
            {
                Subject.GameOver();
            }
        Object.Destroy(go); 
    }
    public void OnUpdateState()
    {

    }
    public void OnExitState()
    {
    }


}