// using System.Collections.Generic;
// using UnityEngine;

// public class Map : MonoBehaviour
// {
//     [SerializeField] int row;
//     [SerializeField] int column;
//     [SerializeField] Brick brickPrefab;
//     [SerializeField] PlayerMove player;
//     int[,] map;
//     Brick[,] brickObjects;

//     public int[,] MapMatrix => map;
//     public Brick[,] BrickObjects => brickObjects;

//     public void GenMap(int level)
//     {
//         DestroyBrick();
//         AddTextWithMaTrix(level);
//         SetBrickWithMatrix();
//     }

//     private void AddTextWithMaTrix(int level)
//     {
//         string textMap = Resources.Load<TextAsset>($"Maps/Map{level}").text;
//         string[] splitRow = textMap.Split('\n');
//         row = splitRow.Length;
//         column = splitRow[0].Split(',').Length;
//         map = new int[row, column];
//         brickObjects = new Brick[row, column];

//         for (int i = 0; i < row; i++)
//         {
//             var tmp = splitRow[i].Split(',');
//             for (int j = 0; j < column; j++)
//             {
//                 map[i, j] = int.Parse(tmp[j]);
//             }
//         }
//     }

//     private void SetBrickWithMatrix()
//     {
//         for (int i = 0; i < row; i++)
//         {
//             for (int j = 0; j < column; j++)
//             {
//                 Vector3 position = new Vector3(i, 0, j);
//                 Brick brick = Instantiate(brickPrefab, position, Quaternion.identity, transform);
//                 brickObjects[i, j] = brick;
//                 brick.brickType = GetBrickType(map[i, j], brick);
//             }
//         }
//     }

//     private Brick.BrickType GetBrickType(int brickCode, Brick brick)
//     {
//         if (brickCode == 1) return Brick.BrickType.AddBrick;
//         if (brickCode == 2) return Brick.BrickType.RemoveBrick;
//         if (brickCode == 3)
//         {
//             player.transform.position = brick.transform.position;
//             return Brick.BrickType.StartPos;
//         }
//         if (brickCode == 4) return Brick.BrickType.EndPos;
//         return Brick.BrickType.Void;
//     }

//     public void DestroyBrick()
//     {
//         foreach (Transform child in transform)
//         {
//             Destroy(child.gameObject);
//         }
//     }
// }
