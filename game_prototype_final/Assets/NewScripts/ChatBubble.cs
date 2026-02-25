// using System.Numerics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEditor.VersionControl;
using UnityEngine;

public class ChatBubble : MonoBehaviour
{
    public static void Create(Transform parent, Vector3 localPosition,string text)
    {
        Transform chatBubbleTransform = Instantiate(GameAssets.i.pfChatBubble, parent);
        chatBubbleTransform.localPosition = localPosition;
        chatBubbleTransform.GetComponent<ChatBubble>().Setup( text);

    }
   
    private SpriteRenderer backgroundSpriteRenderer;
    private SpriteRenderer iconSpriteRenderer;
    private TextMeshPro textMeshPro;
    private void Awake()
    {
        backgroundSpriteRenderer = transform.Find("Background").GetComponent<SpriteRenderer>();
        iconSpriteRenderer = transform.Find("Icon").GetComponent<SpriteRenderer>();
        textMeshPro = transform.Find("Text").GetComponent<TextMeshPro>();
    
    }

    private void Start()
    {
        Setup("Hello World! Here is more text to test out longer messages!");
    }
private void Setup (string text)
    {
        textMeshPro.SetText(text);
        textMeshPro.ForceMeshUpdate();
       Vector2 textSize = textMeshPro.GetRenderedValues(false);

       Vector2 padding = new Vector2(7f, 2f);
       backgroundSpriteRenderer.size = textSize + padding;

       backgroundSpriteRenderer.transform.localPosition = new Vector3(backgroundSpriteRenderer.size.x / 50, 0.5f);


        
    }

}
