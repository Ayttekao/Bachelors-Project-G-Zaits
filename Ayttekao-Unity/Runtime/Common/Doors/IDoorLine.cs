using UnityEngine;

namespace Ayttekao.Unity
{
    public interface IDoorLine
    {
        Vector3Int From { get; }

        Vector3Int To { get; }

        int Length { get; }
    }
}