using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public string name;
    public float attack;
    public bool canDestroyWall;
    public float wallDamage;
    public float durability;
    public ArrayList effectsInflicted = new ArrayList();
    public string description;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
