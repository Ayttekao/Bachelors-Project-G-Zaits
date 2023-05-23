using System;
using UnityEditor;
using UnityEngine;

namespace Ayttekao.Unity.Editor
{
    [Serializable]
    public class AyttekaoSettingsGeneral
    {
        public bool SnapLevelGraphToGrid = true;

        public bool DoubleClickToConfigureRoom = true;

        internal class Inspector : AyttekaoSettingsInspectorBase
        {
            public Inspector(SerializedObject serializedObject) : base(serializedObject, nameof(AyttekaoSettings.General))
            {
            }

            public override void OnGUI()
            {
                GUILayout.BeginVertical(EditorStyles.helpBox);
                Show = EditorGUILayout.Foldout(Show, "General settings");
                if (Show)
                {
                    EditorGUILayout.PropertyField(Property(nameof(SnapLevelGraphToGrid)));
                    EditorGUILayout.PropertyField(Property(nameof(DoubleClickToConfigureRoom)));
                }
                GUILayout.EndVertical();
            }
        }
    }
}