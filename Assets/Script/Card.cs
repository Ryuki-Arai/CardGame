using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Card
{
    public int level;
    public int atk, def, tec, hp;
    public Category category;
    public int rarity;
    public Ability?[] ability = new Ability[4];

    public int Level { get => level; }
    public int Atk { get => atk; }
    public int Def { get => def; }
    public int Tec { get => tec; }
    public int Hp { get => hp; }
    public int Rarity { get => rarity;}

    public abstract void Skill();

    public void Buff()
    {
        foreach (var abl in ability)
        {
            if (abl != null)
            {
                abl.Activate();
            }
        }
        switch (category)
        {
            case Category.Neutral:
                break;
            case Category.Fire:
                break;
            case Category.Water:
                break;
            case Category.Breeze:
                break;
            case Category.Grand:
                break;
        }
    }
}

public enum Category
{
    Neutral,
    Fire,
    Water,
    Breeze,
    Grand,
}
