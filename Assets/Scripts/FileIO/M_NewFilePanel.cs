using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.Collections;

public class M_NewFilePanel : MonoBehaviour {
    public Text CurrentFilePath;
    public Text NewFIleName;


    void Awake()
    {
        this.gameObject.SetActive(false);
    }

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
        this.gameObject.SetActive(false);
    }

    public void ExitPanel()
    {
        this.gameObject.SetActive(false);
    }
}
