namespace EditorCools.Editor
{
    using UnityEditor;
    using UnityEngine;

    /// <summary>
    /// Property drawer for <see cref="EditorCools.DisabledWhenNotPlayAttribute"/>.
    /// Disables the field while the game is NOT playing (i.e. in edit mode).
    /// </summary>
    [CustomPropertyDrawer(typeof(DisabledWhenNotPlayAttribute))]
    public class DisabledWhenNotPlayAttributePropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            // Disable when the editor is NOT in play mode (edit mode).
            var disabled = !EditorApplication.isPlaying;

            EditorGUI.BeginDisabledGroup(disabled);
            EditorGUI.PropertyField(position, property, label, true);
            EditorGUI.EndDisabledGroup();
        }
    }
}
