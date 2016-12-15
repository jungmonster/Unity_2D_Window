using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class M_ContentPanel : MonoBehaviour , IF_FileChange{
    public Text contentPanel_FileName;
    public Text contentPanel_FileContent;

	void Start () {

	}
	
	void Update () {
	
	}

    public void FileChange()
    {
        if(FileData.GetIstance == null)
        {
            Debug.Log("tidfdsfhasd : " + FileData.GetIstance.ToString());
        }
        Debug.Log("DDDD : " + FileData.GetIstance.fileName);
        contentPanel_FileName.text = FileData.GetIstance.fileName;
        contentPanel_FileContent.text = FileData.GetIstance.strBuf;

    }

    public void SaveButton()
    {
        FileData.GetIstance.WriteFileContent(contentPanel_FileContent.text);
    }
}
