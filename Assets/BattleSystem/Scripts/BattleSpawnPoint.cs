using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BattleSystem{
    public class BattleSpawnPoint : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        public BattleCharacter Spawn(BattleCharacter character){
            BattleCharacter characterToSpawn = Instantiate<BattleCharacter>(character, this.transform);
            return characterToSpawn;
        }
    }
}