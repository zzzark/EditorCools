namespace EditorCools.Editor
{
    using UnityEditor;
    using UnityEngine;

    /// <summary>
    /// Property drawer for <see cref="EditorCools.DisabledWhenPlayAttribute"/>.
    /// Disables the field while the game is playing.
    /// </summary>
    [CustomPropertyDrawer(typeof(DisabledWhenPlayAttribute))]
    public class DisabledWhenPlayAttributePropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            // Disable when the editor is in play mode.
            var disabled = EditorApplication.isPlaying;

            EditorGUI.BeginDisabledGroup(disabled);
            EditorGUI.PropertyField(position, property, label, true);
            EditorGUI.EndDisabledGroup();
        }
    }
}
