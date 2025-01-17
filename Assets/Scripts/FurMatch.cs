﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("GorillaShirts/FurMatch")]
public class FurMatch : MonoBehaviour
{
    public enum FurMode
    {
        Default, Coloured, Match
    }

    [Tooltip("Default: Material is set to the default fur material\n\nColoured: Material is set to the default fur material of the player which includes their colour\n\nMatch: Material is set to the fur material of the player which includes lava, rock, and more")]
    public FurMode mode;
}
