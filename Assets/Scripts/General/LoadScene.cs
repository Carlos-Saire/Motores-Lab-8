using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void Scene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
