using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TestCaller : MonoBehaviour {

    MonoObserver callertest;
    GameObject[] callList;
	void Start () {
        callertest = new MonoObserver();

        callList = GameObject.FindGameObjectsWithTag("Caller");

        foreach(GameObject call in callList)
        {
            callertest.Attach(call.GetComponent<Caller01>());
        }
	}
	
	void Update () {
	
	}

    public void BtnEvent()
    {
        callertest.Notify();
    }
}
