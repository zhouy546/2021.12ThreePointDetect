using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ThreePointsLib;

public class PointTest : MonoBehaviour
{
    Touch[] touches;

    public Transform TESTUI;

    public List<ThreePointsLib.Node> M_Nodes = new List<ThreePointsLib.Node>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        touches = Input.touches;

        List<Vector3> touchPosition = new List<Vector3>();
        foreach (var touch in touches)
        {
            //       Debug.Log(touch.phase.ToString() + "  " + touch.fingerId + "  " + touch.position);

            touchPosition.Add(touch.position);
        }
        M_Nodes = pointManager.GetNODES(touchPosition, 45f, 90f, 45f);

        foreach (var node in M_Nodes)
        {
            TESTUI.position = node.centerPos;
            TESTUI.rotation = Quaternion.Euler(0, 0, -node.Rotangle);
        }
    }
}
