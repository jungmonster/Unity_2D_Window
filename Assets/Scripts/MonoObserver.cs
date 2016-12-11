using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MonoObserver {

    
    private List<testInterface> callList = new List<testInterface>();

    public void Attach(testInterface call)
    {
        callList.Add(call);
    }

    public void Notify()
    {
        foreach ( testInterface calllist in callList )
        {
            calllist.ChangeCall(); 
        }
    }
	
}
