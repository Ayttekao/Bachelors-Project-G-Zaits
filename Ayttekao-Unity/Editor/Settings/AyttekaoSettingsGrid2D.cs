using System;
using UnityEditor;
using UnityEngine;

namespace Ayttekao.Unity.Editor
{
    [Serializable]
    public class AyttekaoSettingsGrid2D
    {
        internal class Inspector : AyttekaoSettingsInspectorBase
        {
            public Inspector(SerializedObject serializedObject) : base(serializedObject, nameof(AyttekaoSettings.Grid2D))
            {
            }

            public override void OnGUI()
            {
                GUILayout.BeginVertical(EditorStyles.helpBox);
                Show = EditorGUILayout.Foldout(Show, "Grid2D settings (empty for now)");
                if (Show)
                {

                }
                GUILayout.EndVertical();
            }
        }
    }
}