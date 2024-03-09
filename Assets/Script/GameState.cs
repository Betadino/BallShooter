public sealed class GameState
{
    private static GameState instance = null;
    public static int shotsFired { get; set; }
    public static int spheresKilled { get; set; }
    public static int score { get; set; }
    public static int life { get; set; }

    private GameState() {
        GameState.shotsFired = 0;
        GameState.spheresKilled = 0;
        GameState.score = 0;
        GameState.life =2;
    }

    
    public static GameState Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameState();
            }
            return instance;
        }
        
    }

}