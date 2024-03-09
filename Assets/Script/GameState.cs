public sealed class GameState
{
    private static GameState instance = null;
    public static int shotsFired { get; set; }
    public static int spheresKilled { get; set; }
    public static int score { get; set; }
    public static int life { get; set; }

    private GameState() {}

    
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