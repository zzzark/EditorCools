namespace EditorCools
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Disables a field/property in the inspector while the game is playing.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class DisabledWhenPlayAttribute : PropertyAttribute
    {
    }
}
