using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QuestSystem;

public class DemonSlayerQuest : Quest{
    void Awake(){
        questName = "Demon Hunter";
        description = "Slay some demons.";
        itemRewards = new List<string>() {"Burnt Salmon", "Rusty Chains"};
        goal = new KillGoal(1, 0, this);

    }

    public override void Complete(){
        base.Complete();
    }

}

