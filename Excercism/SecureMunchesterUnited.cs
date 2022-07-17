/*
Casting and type conversion are different ways of changing an expression from one data type to another.

An expression can be cast to another type with the cast operator (<type>).


The class hierarchy of the backroom staff is as follows

TeamSupport (interface)
├ Chairman
├ Manager
└ Staff (abstract)
    ├ Physio
    ├ OffensiveCoach
    ├ GoalKeepingCoach
    └ Security
        ├ SecurityJunior
        ├ SecurityIntern
        └ PoliceLiaison

*/

using System;
public class SecurityPassMaker
{
    public string GetDisplayName(ITeamSupport support)
    {
        if (support is Staff)
        {
            var displayName = support.Title;
            if (support is Security)
            {
                if (!(support is SecurityJunior) && !(support is SecurityIntern) && !(support is PoliceLiaison))
                    displayName += " Priority Personnel";
            }
            return displayName;
        }
        else return "Too Important for a Security Pass";
    }
}
/**** Please do not alter the code below ****/
public interface ITeamSupport { string Title { get; } }
public abstract class Staff : ITeamSupport { public abstract string Title { get; } }
public class Manager : ITeamSupport { public string Title { get; } = "The Manager"; }
public class Chairman : ITeamSupport { public string Title { get; } = "The Chairman"; }
public class Physio : Staff { public override string Title { get; } = "The Physio"; }
public class OffensiveCoach : Staff { public override string Title { get; } = "Offensive Coach"; }
public class GoalKeepingCoach : Staff { public override string Title { get; } = "Goal Keeping Coach"; }
public class Security : Staff { public override string Title { get; } = "Security Team Member"; }
public class SecurityJunior : Security { public override string Title { get; } = "Security Junior"; }
public class SecurityIntern : Security { public override string Title { get; } = "Security Intern"; }
public class PoliceLiaison : Security { public override string Title { get; } = "Police Liaison Officer"; }
