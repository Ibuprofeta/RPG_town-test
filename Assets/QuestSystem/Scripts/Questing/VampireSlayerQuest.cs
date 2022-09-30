using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QuestSystem;

public class VampireSlayerQuest : Quest{
    void Awake(){
        questName = "Vampire Slayer";
        description = "Slay some vampires.";
        itemRewards = new List<string>() {"Burnt Salmon", "Rusty Chains"};
        goal = new KillGoal(10, 0, this);

    }

    public override void Complete(){
        base.Complete();
    }

}

