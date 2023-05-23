using Ayttekao.GraphBasedGenerator.Grid2D;

namespace Ayttekao.Unity
{
    public interface IDoorModeDataGrid2D
    {
        IDoorModeGrid2D GetDoorMode(DoorsGrid2D doors);
    }
}