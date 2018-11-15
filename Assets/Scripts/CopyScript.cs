using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyScript : Photon.MonoBehaviour {

    public GameObject camera;


    private void Start()
    {

        if (photonView.isMine == true && PhotonNetwork.connected == true)
        {
            GetComponent<PhotonVoiceRecorder>().enabled = true;
        }/*
        else
        {
            GetComponent<CopyScript>().enabled = false;
        }*/
        
    }


    // Update is called once per frame
    void Update () {
        if (photonView.isMine == true && PhotonNetwork.connected == true)
        {
            transform.rotation = Cardboard.SDK.HeadPose.Orientation;
        }
	}
}
