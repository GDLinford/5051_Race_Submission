using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemuse : MonoBehaviour
{

    private ItemHandler itemH;
    private Controller car;

    public float IPickupDelay = 1;

    public int ItemHeld;

    public bool CanPickup;
    private bool use;

    public Items ItemToUse;
    private int UsesLeft;


    // Start is called before the first frame update
    private void Start()
    {
        itemH = GameObject.FindGameObjectWithTag("GameController").GetComponent<ItemHandler>();

        car = GetComponent<Controller>();

        resetI();
    }

    // Update is called once per frame
    void Update()
    {
        use = Input.GetButtonDown("UsingItem");
        if (ItemToUse && ItemHeld != -1)
        {
            UseTheItem();
        }
    }

    public void PickupBegin()
    {
        StartCoroutine(Pickup());
    }

    public IEnumerator Pickup()
    {
        if (ItemHeld == -1 && CanPickup)
        {
            CanPickup = false;

            yield return new WaitForSeconds(IPickupDelay);

            int RandomItem = Random.Range(0, itemH.Items.Length);

            ItemToUse = itemH.Items[RandomItem];

            ItemHeld = RandomItem;
            UsesLeft = ItemToUse.numOfUses;
        }
    }

    public void UseTheItem()
    {
        UsesLeft -= 1;

        if (ItemToUse.boosts.Length > 0)
        {
            foreach (ItemBoost Iboosts in ItemToUse.boosts)
            {
                car.carBoost(Iboosts.Boost);
            }
        }

        if (UsesLeft <= 0)
        {
            resetI();
        }
    }

    public void resetI()
    {
        ItemToUse = null;
        ItemHeld = -1;
        CanPickup = true;
    }
}
