namespace EditorCools
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Disables a field/property in the inspector while the game is NOT playing (i.e. in edit mode).
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class DisabledWhenNotPlayAttribute : PropertyAttribute
    {
    }
}
