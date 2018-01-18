using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraineeControl : PartySystem {

    public List<Trainee> trainees;
    public List<Trainee> traineesInUse;

    private void Start()
    {
        trainees = new List<Trainee>();
        traineesInUse = new List<Trainee>();
    }

    public void AssignTrainee(PartySystem system, Trainee trn)
    {
        trn.AssignedSystem = system;
    }
}

/**
 * Each system has a max amount of trainees it can use
 * This is based on the size (number of squares) within the system
 * Possible ways to decide this size:
 * -Preset sizes, Preset layouts
 * -Preset sizes, User made layouts (I like this one)
 * -User decided Size [Not Required Rectangular], User made Layouts
 * -User decided Size [Required Rectangular], User Made Layouts
 * 
 * Once a trainee is assigned to a system, it can be moved, but not during a fight
 * Trainees will slowly "repair the system". Much slower than a healer, but increases linearly with each trainee.
 */

/**
 * User Layouts Idea
 * 1. User is given set size of units to take with them.
 * 2. Each system has a size of its own, and trainees fill the rest
 * 
 * Alternative User Layouts Idea
 * [Required Rectangular]
 * 1. User can draw area for each system, as long as it is rectangular.
 * 2. Trainee amount is decided by trainee control size
 * 
 * Alternative User Layouts Idea
 * [Not Reqiuired Rectangular]
 * 1. User can draw area for each system. Can be any shape, but all blocks of a system must be touching.
 * 2. Trainee amount is decided by trainee control size
 */
