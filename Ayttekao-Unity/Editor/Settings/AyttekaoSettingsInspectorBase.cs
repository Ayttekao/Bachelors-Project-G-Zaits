using UnityEditor;

namespace Ayttekao.Unity.Editor
{
    internal abstract class AyttekaoSettingsInspectorBase
    {
        protected readonly SerializedObject SerializedObject;
        protected readonly string SectionName;
        protected bool Show = false;

        protected AyttekaoSettingsInspectorBase(SerializedObject serializedObject, string sectionName)
        {
            SerializedObject = serializedObject;
            SectionName = sectionName;
        }

        public abstract void OnGUI();

        protected SerializedProperty Property(string name)
        {
            return SerializedObject.FindProperty($"{SectionName}.{name}");
        }
    }
}