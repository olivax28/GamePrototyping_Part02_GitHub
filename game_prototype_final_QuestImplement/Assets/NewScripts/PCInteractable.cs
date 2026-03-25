using UnityEngine;
using UnityEngine.SceneManagement;

public class MainPC: MonoBehaviour, IInteractable

{
    public GameObject ObjectToActivate;

    public string GetInteractText()
    {
        return "Use Computer";
    }

    public void Interact(Transform interactorTransform)
    {
        toMenu();
    }

    public void toMenu()
    {
       ObjectToActivate.SetActive(true) ;
    }
}
