using UnityEngine;
using UnityEngine.SceneManagement;

public class restartScene : MonoBehaviour
{
    public void restart()
    {
        SceneManager.LoadScene("Andre");
    }
}
