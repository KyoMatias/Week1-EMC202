using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    public Block[] Blocks;

    private void Start()
    {
        foreach (var block in Blocks)
        {
            block.DebugSelf();
        }
    }
}
