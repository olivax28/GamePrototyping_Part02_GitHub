using UnityEngine;

public class itemScript : MonoBehaviour

{
  
  private InventoryController inventoryController;

  void Start()
    {
        inventoryController = FindAnyObjectByType<InventoryController>();
    }

  void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Item"))
        {
            Item item = collision.GetComponent<Item>();
            if(item != null)
            {
                bool itemAdded = inventoryController.AddItem(collision.gameObject);

                if (itemAdded)
                {
                    Destroy(collision.gameObject);
                    
                }
            }
        }
    }

}
