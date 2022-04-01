using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{
    public int atk, def, tec, hp;
    public Category category;
    public int rarity;
    public Ability?[] ability = new Ability[4];

    public int Atk { get => atk; }
    public int Def { get => def; }
    public int Tec { get => tec; }
    public int Hp { get => hp; }
    public int Rarity { get => rarity;}

    public void Skill()
    {
        foreach(var abl in ability)
        {
            if(abl != null)
            {
                abl.Activate();
            }
        }
    }
}
public enum Category
{
    Neutral = 0,
    Fire = 1,
    Water = 2,
    breeze = 3,
    Grand = 4,
}
