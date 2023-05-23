using Ayttekao.Geometry;

namespace Ayttekao.Unity
{
    public static class IntVector2Helper
    {
        public static AyttekaoVector2Int Top => new AyttekaoVector2Int(0, 1);

        public static AyttekaoVector2Int Right => new AyttekaoVector2Int(1, 0);

        public static AyttekaoVector2Int Bottom => new AyttekaoVector2Int(0, -1);

        public static AyttekaoVector2Int Left => new AyttekaoVector2Int(-1, 0);

        public static AyttekaoVector2Int TopLeft => new AyttekaoVector2Int(-1, 1);

        public static AyttekaoVector2Int TopRight => new AyttekaoVector2Int(1, 1);

        public static AyttekaoVector2Int BottomLeft => new AyttekaoVector2Int(-1, -1);

        public static AyttekaoVector2Int BottomRight => new AyttekaoVector2Int(1, -1);
    }
}