using UnityEngine;
using UnityEngine.SceneManagement;

public class EndPC: MonoBehaviour, IInteractable

{
   

    public string GetInteractText()
    {
        return "Use...Computer?";
    }

    public void Interact(Transform interactorTransform)
    {
        restart();
    }

    public void restart()
    {
       SceneManager.LoadScene("Game");
    }
    
}

