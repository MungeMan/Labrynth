using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string name;
    public int healthUp;
    public float speedTo;
    public bool keyItem;
    public int maxHealthUp;
    public float stopwatch;
    public bool timeLimit;
    public float defenseModifier;
    public float attackModifier;
    public string description;
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.tag);
        if (collision.gameObject.tag == "Player")
        {
            if (true)
            {
                player.health = player.health + healthUp;
            }

        }

    }
}
