using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [SerializeField] private Button buttonGame1;
    [SerializeField] private Button buttonCloseGame;
    private void Awake()
    {
        buttonGame1.onClick.AddListener(OnclikGame1);
        buttonCloseGame.onClick.AddListener(OnclikCloseGame);
    }

    private void OnclikGame1()
    {
        SceneManager.LoadScene("Game1");
    }

    private void OnclikCloseGame()
    {
        Application.Quit();
        Debug.Log("Saliste Del juego");
    }

}
