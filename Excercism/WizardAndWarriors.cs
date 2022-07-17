/*
 * In C#, a class hierarchy can be defined using inheritance, 
 * which allows a derived class (Car) to inherit the behavior and data of its parent class (Vehicle). 
 * If no parent is specified, the class inherits from the object class
 * */

using System;

abstract class Character
{

    string characterType;


    protected Character(string characterType)
    {
        this.characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => false;

    public override string ToString() => ($"Character is a {characterType}");
}

class Warrior : Character
{
    public Warrior() : base("Warrior") { }

    public override int DamagePoints(Character target) =>
        target.Vulnerable() ? 10 : 6;
}

class Wizard : Character
{
    bool spellPrepared = false;


    public Wizard() : base("Wizard") { }

    public override bool Vulnerable() => !spellPrepared ? true : false;

    public override int DamagePoints(Character target) =>
        spellPrepared ? 12 : 3;


    public void PrepareSpell()
    {
        spellPrepared = true;
    }
}