using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemButton : MonoBehaviour
{
    public ItemButton data;
    public Image icon;

    public static implicit operator ItemButton(ItemData v)
    {
        throw new NotImplementedException();
    }
}
