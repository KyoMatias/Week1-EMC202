using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondBlock : Block
{
    private int _mana;
    private int _durability;
    
    public override void DebugSelf()
    {
        Debug.Log($"And I am an Diamond Block");
    }
}
