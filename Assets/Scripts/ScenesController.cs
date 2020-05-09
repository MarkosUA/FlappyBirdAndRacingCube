using UnityEngine.SceneManagement;

public static class ScenesController
{
    private static string _menuSceneIndex = "MenuScene";
    private static string _hotWheelSceneIndex = "HotWheels";
    private static string _flappyBirdSceneIndex = "FlappyBird";

    public static void LoadMenuScene()
    {
        SceneManager.LoadScene(_menuSceneIndex);
    }

    public static void LoadHotWheelScene()
    {
        SceneManager.LoadScene(_hotWheelSceneIndex);
    }

    public static void LoadFlappyBirdScene()
    {
        SceneManager.LoadScene(_flappyBirdSceneIndex);
    }
}
