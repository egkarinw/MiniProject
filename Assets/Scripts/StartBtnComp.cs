using UnityEngine;
using UnityEngine.SceneManagement;

public class StartBtnComp : MonoBehaviour
{
    public void OnPressStartButton()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
