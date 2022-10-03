using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BattleSystem{
    public class BattleCharacter : MonoBehaviour{
        public string characterName;
        public int health;
        public int maxHealth;
        public int attackPower;
        public int defensePower;
        public int manaPoints;
        public List<Spell> spells;

        public void Hurt (int amount){
            int damageAmount =  amount - defensePower;
            health = Mathf.Max(health - damageAmount, 0);
            
                print (characterName + health);
            if (health <= 0){
                Die();
            }
        }

        public void Heal (int amount){
            health = Mathf.Min(health + amount, maxHealth);
        }

        public void Defend(){
            defensePower += (int)(defensePower * .33);
            Debug.Log("Def increased");
            BattleController.Instance.NextActDefend();
        }

        public bool CastSpell(Spell spell, BattleCharacter targetCharacter){
            bool successful = manaPoints >= spell.manaCost;

            if (successful){
                Spell spellToCast = Instantiate<Spell>(spell, transform.position,
                Quaternion.identity);
                manaPoints -= spell.manaCost;
                spellToCast.Cast(targetCharacter);
            }

            return successful;
        }

        public virtual void Die(){
            Destroy(gameObject);
            Debug.LogFormat("{0} has died.", characterName);
        }
    }
}