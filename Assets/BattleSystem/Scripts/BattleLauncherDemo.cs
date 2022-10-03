using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BattleSystem{
    public class BattleLauncherDemo : MonoBehaviour
    {
        [SerializeField]
        private List<BattleCharacter> players, enemies;
        [SerializeField]
        private BattleLauncher launcher;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            
        }
        
        public void Launch(){
            //launcher.PrepareBattle(enemies, players);
        }
    }
}

