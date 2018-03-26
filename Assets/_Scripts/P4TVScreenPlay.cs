using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P4TVScreenPlay : MonoBehaviour
{
    [SerializeField]
    MovieTexture m_movie;

    [SerializeField]
    Texture m_trouble;

    enum P4TVState
    {
        normalState,
        abnormalState,
    }
	void Start ()
    {
        int p4TVStatus = Random.Range(0, 2);
        TVStatus((P4TVState)p4TVStatus);
    }
	
    void TVStatus(P4TVState StatusNum)
    {
        switch (StatusNum)
        {
            case P4TVState.normalState:
                {
                    GetComponent<Renderer>().material.mainTexture = m_movie;
                    m_movie.loop = true;
                    m_movie.Play();
                    break;
                }
            case P4TVState.abnormalState:
                {
                    GetComponent<Renderer>().material.mainTexture = m_trouble;
                    break;
                }
            default:
                break;
        }
    }
	
}
