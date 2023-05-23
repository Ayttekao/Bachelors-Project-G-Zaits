using System.Collections.Generic;
using UnityEngine;

namespace Ayttekao.Unity
{
    /// <summary>
    /// Set of room templates that can be stored inside a scriptable object.
    /// </summary>
    [CreateAssetMenu(fileName = "RoomTemplatesSet", menuName = "Ayttekao/Room templates set")]
    public class RoomTemplatesSet : ScriptableObject
    {
        public List<GameObject> RoomTemplates = new List<GameObject>();
    }
}