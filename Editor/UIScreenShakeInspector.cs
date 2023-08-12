using UnityEditor;
using UnityEngine;

namespace IronMountain.UIScreenShake.Editor
{
    [CustomEditor(typeof(UIScreenShake), true)]
    public class UIScreenShakeInspector : UnityEditor.Editor
    {
        private UIScreenShake _uiScreenShake;
        
        private void OnEnable()
        {
            _uiScreenShake = (UIScreenShake) target;
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            GUILayout.Space(10);
            GUILayout.BeginHorizontal();
            GUILayout.Label("Shake This", GUILayout.MaxWidth(100));
            if (GUILayout.Button("25%")) _uiScreenShake.Shake(.25f, 1);
            if (GUILayout.Button("50%")) _uiScreenShake.Shake(.50f, 1);
            if (GUILayout.Button("75%")) _uiScreenShake.Shake(.75f, 1);
            if (GUILayout.Button("100%")) _uiScreenShake.Shake(1f, 1);
            GUILayout.EndHorizontal();
            GUILayout.BeginHorizontal();
            GUILayout.Label("Shake Global", GUILayout.MaxWidth(100));
            if (GUILayout.Button("25%")) UIScreenShake.GlobalShake(.25f, 1);
            if (GUILayout.Button("50%")) UIScreenShake.GlobalShake(.50f, 1);
            if (GUILayout.Button("75%")) UIScreenShake.GlobalShake(.75f, 1);
            if (GUILayout.Button("100%")) UIScreenShake.GlobalShake(1f, 1);
            GUILayout.EndHorizontal();
            if (GUILayout.Button("Reset")) _uiScreenShake.Reset();
        }
    }
}