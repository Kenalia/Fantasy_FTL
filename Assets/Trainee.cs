using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trainee : Unit {

    public PartySystem AssignedSystem { get; set; }

    private void Start()
    {
        AssignedSystem = GetComponent<Realm>().trnControl;

        //Assign random name

        Health = 100;
    }

}
