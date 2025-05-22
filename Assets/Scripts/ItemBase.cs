using UnityEngine;

public class ItemBase : MonoBehaviour, IInteractable
{
    public ItemData data;

    public void Interact()
    {
        Debug.Log ("Interation item : " +data.name);
        InventoryManager.instance.AddItem(data);
        Destroy(gameObject);
    }
}
