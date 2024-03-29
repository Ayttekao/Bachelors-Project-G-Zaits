﻿using UnityEngine;

#region codeBlock:2d_example1_postProcessing

namespace Ayttekao.Unity.Examples.Example1
{
    [CreateAssetMenu(menuName = "Ayttekao/Examples/Example 1/Post-processing", fileName = "Example1PostProcessing")]
    public class Example1PostProcessing : DungeonGeneratorPostProcessingGrid2D
    {
        [Range(0, 1)]
        public float EnemySpawnChance = 0.5f;

        public override void Run(DungeonGeneratorLevelGrid2D level)
        {
            HandleEnemies(level);
        }

        private void HandleEnemies(DungeonGeneratorLevelGrid2D level)
        {
            // Iterate through all the rooms
            foreach (var roomInstance in level.RoomInstances)
            {
                // Get the transform that holds all the enemies
                var enemiesHolder = roomInstance.RoomTemplateInstance.transform.Find("Enemies");

                // Skip this room if there are no enemies
                if (enemiesHolder == null)
                {
                    continue;
                }

                // Iterate through all enemies (children of the enemiesHolder)
                foreach (Transform enemyTransform in enemiesHolder)
                {
                    var enemy = enemyTransform.gameObject;

                    // Roll a dice and check whether to spawn this enemy or not
                    // Use the provided Random instance so that the whole generator uses the same seed and the results can be reproduced
                    if (Random.NextDouble() < EnemySpawnChance)
                    {
                        enemy.SetActive(true);
                    }
                    else
                    {
                        enemy.SetActive(false);
                    }
                }
            }
        }
    }
}

#endregion