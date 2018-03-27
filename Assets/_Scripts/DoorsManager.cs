using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorsManager : MonoBehaviour
{

    public void OpenDoors() {
        BroadcastMessage("Open");
    }
    public void CloseDoors()
    {
        BroadcastMessage("Close");
    }
}
