using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Items : ScriptableObject
{
    public string ItemName;
    public int numOfUses;

    public ItemBoost[] boosts;
}
