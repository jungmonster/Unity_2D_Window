using UnityEngine;
using System.Collections;

public class Caller01 : MonoBehaviour , testInterface{

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ChangeCall()
    {
        Debug.Log("Caller 01");
    }
}
