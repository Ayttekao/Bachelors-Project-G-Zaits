using Ayttekao.GraphBasedGenerator.Grid2D;
using Ayttekao.Unity.Diagnostics;
using UnityEngine;

namespace Ayttekao.Unity
{
    /// <summary>
    /// Class that describes the structure of a level. It contains all the rooms, connections and available room templates.
    /// </summary>
    public class LevelDescriptionGrid2D : LevelDescriptionBase
    {
        protected override bool TryGetRoomTemplate(GameObject roomTemplatePrefab, out RoomTemplateGrid2D roomTemplate, out ActionResult result)
        {
            return RoomTemplateLoaderGrid2D.TryGetRoomTemplate(roomTemplatePrefab, out roomTemplate, out result);
        }
    }
}