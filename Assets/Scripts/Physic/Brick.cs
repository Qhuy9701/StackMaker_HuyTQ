using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    [SerializeField] private Material whiteMaterial;
    [SerializeField] private Material violetMaterial;
    [SerializeField] private Material yellowMaterial;
    [SerializeField] private Material startMaterialBrick;
    [SerializeField] private Material endMaterialBrick;
    public enum BrickType
    {
        Void,
        RemoveBrick,
        AddBrick,
        StartPos,
        EndPos, 
    }
    public BrickType brickType;

    private void Start()
    {
        OnInit();
    }

    private void OnInit()
    {

        if (brickType == BrickType.Void)
        {
            GetComponent<MeshRenderer>().material = whiteMaterial;
        }
        if (brickType == BrickType.RemoveBrick)
        {
            GetComponent<MeshRenderer>().material = violetMaterial;
        }
        if (brickType == BrickType.AddBrick)
        {
            GetComponent<MeshRenderer>().material = yellowMaterial;
        }
        if (brickType == BrickType.StartPos)
        {
            GetComponent<MeshRenderer>().material = startMaterialBrick;
        }
        if (brickType == BrickType.EndPos)
        {
            GetComponent<MeshRenderer>().material = endMaterialBrick;
        }
    }

}
