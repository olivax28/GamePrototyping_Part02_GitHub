using UnityEngine;

public class NPCInteractable : MonoBehaviour
{
    public void Interact()
    {
        ChatBubble.Create(transform.transform, new Vector3(-.3f,1.7f,0f), "here is a test!");
    }
}
