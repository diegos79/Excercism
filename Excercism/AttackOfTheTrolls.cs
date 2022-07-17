/*
 * A C# Attribute provides a way to decorate a declaration to associate metadata to: 
 * a class, a method, an enum, a field, a property or any other supported declarations.

You can apply an attribute by adding it on the line before the declaration using a 
ClassAttribute and a FieldAttribute:

[Class]
class MyClass
{
    [Field]
    int myField;
}
*/


using System;

// TODO: define the 'AccountType' enum

[Flags]
public enum AccountType : byte
{
    Guest,
    User,
    Moderator
}

// TODO: define the 'Permission' enum

[Flags]
public enum Permission
{
    None = 0,
    Read = 1,
    Write = 2,
    Delete = 4,
    All = 7
}

static class Permissions
{
    public static Permission Default(AccountType accountType)
    {
        Permission result = Permission.None;
        if (accountType == AccountType.Guest)
            result = Permission.Read;
        else if (accountType == AccountType.User)
            result = Permission.Read | Permission.Write;
        else if (accountType == AccountType.Moderator)
            result = Permission.All;
        else result = Permission.None;

        return result;

    }

    public static Permission Grant(Permission current, Permission grant)
    {
        return current | grant;
    }

    public static Permission Revoke(Permission current, Permission revoke)
    {
        return current & ~revoke;
    }

    public static bool Check(Permission current, Permission check)
    {
        return current >= check;
    }
}