using UnityEngine;
using UnityEngine.SceneManagement;

public class MainPC: MonoBehaviour

{
    public GameObject ObjectToActivate;
    public void toMenu()
    {
       ObjectToActivate.SetActive(true) ;
    }
}
