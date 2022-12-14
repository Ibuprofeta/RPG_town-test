using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BattleSystem{    
    public class BattleLaunchCharacter : MonoBehaviour
    {
        [SerializeField]
        private List<BattleSystem.BattleCharacter> players, enemies;
        [SerializeField]
        private BattleSystem.BattleLauncher launcher;

        public void PrepareBattle(Character character){
            launcher.PrepareBattle(enemies, players, character.transform.position);
        }
    }

}