using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public GameObject ObjectToActivate;
  public void BackToGame()
    {
        ObjectToActivate.SetActive(false);
    }
}
