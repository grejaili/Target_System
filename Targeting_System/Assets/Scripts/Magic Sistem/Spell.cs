using UnityEngine;
using System.Collections;

public class Spell  {
    public float CoolDown;
    public int spellId;
    public string spellName;
    public SpellType spellType;

    public Spell(int id, string name, float Cd, SpellType type)
    {
        spellId = id;
        spellName = name;
        CoolDown = Cd;
        spellType = type;
    }

    public enum SpellType
    {
        Bolt_Buff,
        Bolt_Damage,
        Bolt_Heal,
        AoE_Buff,
        AoE_Damage,
        AoE_Heal
    }


    public Spell()
    {
        spellId = -1;
    }
}



