using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void gotoScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

}