using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DP_Observer {

    private List<IF_FileChange> fileChangeCall = new List<IF_FileChange>();

    public void FileChangeCallAttach(IF_FileChange caller)
    {
        fileChangeCall.Add(caller);
    }

    public void FileChangeCall()
    {
        foreach(IF_FileChange callList in fileChangeCall)
        {
            callList.FileChange();
        }
    }

}
