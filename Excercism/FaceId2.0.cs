/*
 * 
Equality

Simple types (strings and primitives) are typically tested for equality with the == and !=.

Reference types (Instances of classes) are compared using the Equals() method inherited from Object. 
If your goal with the equality test is to ensure that two objects are the exact same instance 
then relying on Object's implementation will suffice. 

If not, you need to override object.Equals().

If you know that all the instances of your class are created in one place, 
say characters in some game or simulation then reference equality is sufficient. 
However, it is likely that multiple instances of the same real-world entity will be created
(from a database, by user input, via a web request). 
In this case values that uniquely identify the entity must be tested for equality. 
Therefore Equals() must be overridden and appropriate data members of your class are tested for equality.

An overridden Equals() method will contain equality tests on members of simple types using == 
and reference types with recursive calls to Equals().

The Object class provides appropriate methods to compare two objects to detect if they are one and the same instance.

Object.GetHashCode() 
 * 
 * */

using System;
using System.Collections.Generic;
public class FacialFeatures
{
    public string EyeColor  //property1
    {
        get;
    }
    public decimal PhiltrumWidth //property2
    {
        get;
    }
    public FacialFeatures(string eyeColor, decimal philtrumWidth) //constructor
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }
    public override bool Equals(object obj) //override of method Equals
    {
        return obj is FacialFeatures features &&
               EyeColor == features.EyeColor &&
               PhiltrumWidth == features.PhiltrumWidth;
    }
    public override int GetHashCode() //needed overrride of gethashcode method
    {
        return HashCode.Combine(EyeColor, PhiltrumWidth); //combining hashcode of 2 fields
    }
}

public class Identity2
{
    public string Email //property1
    {
        get;
    }
    public FacialFeatures FacialFeatures //property2 related to facialfeatures class
    {
        get;
    }
    public Identity2(string email, FacialFeatures facialFeatures) //constructor
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }
    public override bool Equals(Object obj) => Equals(obj as Identity2);

    public bool Equals(Identity2 other) => other != null && this.Email.Equals(other.Email) && this.FacialFeatures.Equals(other.FacialFeatures);
    public override int GetHashCode() => HashCode.Combine(this.Email, this.FacialFeatures);
}


public class Authenticator2
{
    private HashSet<Identity2> identities = new ();
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
    {
        return faceA.Equals(faceB);
    }
    public bool IsAdmin(Identity2 identity)
    {
        return identity.Equals(new Identity2("admin@exerc.ism", new FacialFeatures("green", 0.9m)));
    }
    public bool Register(Identity2 identity)
    {
        return identities.Add(identity);
    }
    public bool IsRegistered(Identity2 identity)
    {
        return identities.Contains(identity);
    }
    public static bool AreSameObject(Identity2 identityA, Identity2 identityB)
    {
        return identityA == identityB;
    }
}