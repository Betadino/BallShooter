//THIS IS THE SINGLETON -- it is initialized with lazy init on calling a variable
public sealed class GameData
{
    private static GameData instance = null;
    public static int shotsFired { get; set; }
    public static int spheresKilled { get; set; }
    public static int score { get; set; }
    public static int life { get; set; }

    private GameData() {}

    
    public static GameData Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameData();
            }
            return instance;
        }
        
    }

}