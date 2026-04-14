using UnityEngine;



public class ItemInteractable : MonoBehaviour, IInteractable
{

public GameObject itemThumbnail;
  private InventoryController inventoryController;

  void Start()
    {
        inventoryController = FindAnyObjectByType<InventoryController>();
    }


    [SerializeField] private string interactText;

    public string GetInteractText()
    {
         return interactText;
    }

    public void Interact(Transform interactorTransform)
    {
     TriggerPickup();
    }

public void TriggerSomething()
    {
        Debug.Log("triggersomething");
    }

    private void TriggerPickup()
    {
          
         bool itemAdded = inventoryController.AddItem(gameObject);
         if (itemAdded)
                {
                    Debug.Log("interacted");
                    itemThumbnail.SetActive(true);
                    Destroy(gameObject);
                    TriggerSomething();
                }
    }
    // void OnTriggerEnter(Collider collision)
    // {
    //     if (collision.CompareTag("Item"))
    //     {
    //         Item item = collision.GetComponent<Item>();
    //         if(item != null)
    //         {
    //             bool itemAdded = inventoryController.AddItem(collision.gameObject);

    //             if (itemAdded)
    //             {
    //                 Destroy(collision.gameObject);
    //             }
    //         }
    //     }
    // }



}