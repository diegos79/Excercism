/*
 * The const modifier can be (and generally should be) applied to any field where its value is known at compile time and will not change during the lifetime of the program.

private const int num = 1729;
public const string title = "Grand" + " Master";
The readonly modifier can be (and generally should be) applied to any field that cannot be made const where its value will not change during the lifetime of the program and is either set by an inline initializer or during instantiation (by the constructor or a method called by the constructor).

private readonly int num;
private readonly System.Random rand = new System.Random();

public MyClass(int num)
{
    this.num = num;
}
Readonly Collections
While the readonly modifier prevents the value or reference in a field from being overwritten, it offers no protection for the members of a reference type.
*/

using System.Collections.Generic;

public class Authenticator
{
    private class EyeColor
    {
        public const string Blue = "blue";
        public const string Green = "green";
        public const string Brown = "brown";
        public const string Hazel = "hazel";
        public const string Brey = "grey";
    }
    private Identity admin;

    public Authenticator(Identity admin) //constructor
    {
        this.admin = admin;
    }

    private IDictionary<string, Identity> developers = new Dictionary<string, Identity>
        {
            ["Bertrand"] = new Identity
            {
                Email = "bert@ex.ism",
                EyeColor = "blue"
            },

            ["Anders"] = new Identity
            {
                Email = "anders@ex.ism",
                EyeColor = "brown"
            }
        };

    public Identity Admin
    {
        get { return admin; }
        set { admin = value; }
    }

    public IDictionary<string, Identity> GetDevelopers()
    {
        return developers;
    }
}

public struct Identity
{
    public string Email { get; set; }

    public string EyeColor { get; set; }
}
