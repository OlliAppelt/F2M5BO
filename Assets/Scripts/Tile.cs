using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField]
     private bool _isBuildable;

    public bool HasTower { get; set; }

    public bool GetBuildable()
    {
        return _isBuildable;
    }
}