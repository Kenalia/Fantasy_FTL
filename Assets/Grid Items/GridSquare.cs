using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSquare : MonoBehaviour {

    public List<Unit> occupants;
    public bool Occupied { get; set; }
    public RealmSystemType SystemType { get; set; }

    private void Start()
    {
        SystemType = RealmSystemType.Unassigned;
    }
}
