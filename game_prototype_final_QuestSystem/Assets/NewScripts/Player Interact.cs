using UnityEngine;
using System.Collections.Generic;

public class PlayerInteract : MonoBehaviour
{
   
private void Update(){
        if (Input.GetKeyDown(KeyCode.E)){
            IInteractable interactable = GetInteractableObject();
            if (interactable != null)
            {
                interactable.Interact(transform);
            }
            
        }
        
    }
    public IInteractable GetInteractableObject()
    {
          List<IInteractable> InteractableList = new List<IInteractable>();
         float interactRange = 1.3f;
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach(Collider collider in colliderArray)
            {
                if (collider.TryGetComponent(out IInteractable interactable))
                {
                    InteractableList.Add(interactable);
                    return interactable;
                }
            }
            return null;
    }
        

}
