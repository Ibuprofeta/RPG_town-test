using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    private Rigidbody2D body;
    private SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();   
    }

    // Update is called once per frame
    void Update()
    {
        this.Move(new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")), body, sprite); 
    }

    private void OnTriggerStay2D(Collider2D collision) {
        if (Input.GetButtonDown("Fire1") && collision.GetComponent<Npc>() != null){
            collision.GetComponent<Npc>().StartDialogue();
        }
    }
}
