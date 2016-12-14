using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.Collections;

public class M_NewFilePanel : MonoBehaviour {
    public Text CurrentFilePath;
    public Text NewFIleName;



	void Start () {
        CurrentFilePath.text = FileData.GetIstance.workPath;
    }
	

    public void OpenFilePath()
    {
        FileData.GetIstance.workPath = EditorUtility.OpenFolderPanel("Set Create File Path", FileData.GetIstance.workPath, "");
        CurrentFilePath.text = FileData.GetIstance.workPath;
    }

    public void CreateFile()
    {
        FileData.GetIstance.CreateFile(NewFIleName.text);
    }
}
