using UnityEngine;
using System.Collections;

public class ChangeCubesWithSpace : MonoBehaviour
{
    private GameObject cube0, cube1, cube2, cube3, cube4, cube5;
    private Vector3 PositionCube0;
    private Vector3 PositionCube1;
    private Vector3 PositionCube2;
    private Vector3 PositionCube3;
    private Vector3 PositionCube4;
    private Vector3 PositionCube5;

    bool buleano;

    void Start()
    {
        cube0 = GameObject.Find("Cube0");
        cube1 = GameObject.Find("Cube1");
        cube2 = GameObject.Find("Cube2");
        cube3 = GameObject.Find("Cube3");
        cube4 = GameObject.Find("Cube4");
        cube5 = GameObject.Find("Cube5");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Space ))
        {
            // volvemos a pillar las posiciones de cada uno
            PositionCube0 = cube0.transform.position;
            PositionCube1 = cube1.transform.position;
            PositionCube2 = cube2.transform.position;
            PositionCube3 = cube3.transform.position;
            PositionCube4 = cube4.transform.position;
            PositionCube5 = cube5.transform.position;

            // hacemos el cambiazo
            cube0.transform.position = PositionCube1;
            print(cube0.transform.position);
            cube1.transform.position = PositionCube2;
            cube2.transform.position = PositionCube3;
            cube3.transform.position = PositionCube4;
            cube4.transform.position = PositionCube5;
            cube5.transform.position = PositionCube0;
        }
       
    }
}