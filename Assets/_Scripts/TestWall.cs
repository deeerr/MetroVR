using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestWall : MonoBehaviour
{
    [SerializeField]
    GameObject m_glassWallL;
    [SerializeField]
    GameObject m_glassWallR;


    float xPos;
    float yPos;
    float zPos;
	void Start ()
    {
        NewPosition(m_glassWallL);
        NewPosition(m_glassWallR);
    }

    void NewPosition(GameObject tempObject)
    {
        xPos = tempObject.transform.localPosition.x;
        yPos = tempObject.transform.localPosition.y;
        zPos = tempObject.transform.localPosition.z;
        for (int i = 0; i < 20; i++)
        {
            Instantiate(tempObject, new Vector3(xPos, yPos, zPos), Quaternion.Euler(0, 90, 0), transform.parent);
            xPos -= 4.1f;
        }
    }

	void Update ()
    {
		
	}
}
