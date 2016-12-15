using UnityEngine;
using System.Collections;
using UnityEditor;

public class M_TopMenuButtonEvent : MonoBehaviour {

    public GameObject m_NewFilePanel;

	void Start () {
	
	}

    public void BE_NewFilePanelOpen()
    {
        m_NewFilePanel.SetActive(true);
    }
    
    public void BE_OpenFile()
    {
        string fileName = EditorUtility.OpenFilePanel("Select File", FileData.GetIstance.workPath, "");
        FileData.GetIstance.ReadFileContent(fileName);
    }	
}
