using UnityEngine;

public class NPCInteractable : MonoBehaviour
{
    public void Interact()
    {
        ChatBubble.Create(transform.transform, new Vector3(1f,0.5f,0f), "here is a test!");
    }
}
