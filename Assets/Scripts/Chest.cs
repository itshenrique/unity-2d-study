using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Collectable
{
    public Sprite emptyChest;
    public int pesosAmount = 10;

    protected override void OnCollect()
    {
        if (!collected)
        {
            base.OnCollect(); // collect = true
            GetComponent<SpriteRenderer>().sprite = emptyChest;
            //Debug.Log("Grant " + goldAmount + " gold!");
            GameManager.instance.pesos += pesosAmount;
            GameManager.instance.ShowText("+" + pesosAmount + "gold!", 16, Color.yellow, transform.position, Vector3.up * 40, 1.0f);
        }
        
    }
}
