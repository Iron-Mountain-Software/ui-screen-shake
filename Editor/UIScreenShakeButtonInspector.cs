using UnityEditor;

namespace IronMountain.UIScreenShake.Editor
{
    [CustomEditor(typeof(UIScreenShakeButton), true)]
    public class UIScreenShakeButtonInspector : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            EditorGUILayout.PropertyField(serializedObject.FindProperty("percentMaximum"));
            EditorGUILayout.PropertyField(serializedObject.FindProperty("seconds"));
            EditorGUILayout.PropertyField(serializedObject.FindProperty("shakeGlobally"));
            if (!serializedObject.FindProperty("shakeGlobally").boolValue)
            {
                EditorGUILayout.PropertyField(serializedObject.FindProperty("componentsToShake"));
            }
            serializedObject.ApplyModifiedProperties();
        }
    }
}
