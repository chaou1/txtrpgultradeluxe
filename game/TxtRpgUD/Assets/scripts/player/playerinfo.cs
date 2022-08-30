using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerinfo : MonoBehaviour
{
    public string Name = "Pain";
    public double maxhealth;
    public double health;
    public double attack;
    public double defense;
    public double maxmana;
    public double mana;
    public double geld;
    public double neu;
    public double exp;
    public double level;
    void Start()
    {
        maxhealth = 10;
        health = 10;
        attack = 1;
        defense = 1;
        maxmana = 10;
        mana = 10;
        geld = 100;
        exp = 0;
        level = 1;
    }
    public void upgrade(string stat, int p)
    {
        switch (stat) {
            case maxhealth:
                break;
        
        
        }
    }

    public void Crit()
    {




    }
    void Update()
    {

    }
}
