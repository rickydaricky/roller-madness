using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oi : MonoBehaviour
{
    // Use this for initialization, citation: 
    void Start()
    {
        /* Material newMaterial = new Material();
        ObjImporter newMaterial = new ObjImporter();
        holderMesh = newMesh.ImportFile("C:/Users/rickydaricky/Documents/GitHub/Unity-Projects/Solar System/Assets/Textures/jupitermap");
        */
        MeshRenderer renderer = gameObject.AddComponent<MeshRenderer>();
        MeshFilter filter = gameObject.AddComponent<MeshFilter>();
        //filter.mesh = holderMesh;
    }
}