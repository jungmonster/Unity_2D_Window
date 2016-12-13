using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class M_ContentPanel : MonoBehaviour , IF_FileChange{
    public Text contentPanel_FileName;
    public Text contentPanel_FileContemt;

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
        contentPanel_FileContemt.text = FileData.GetIstance.strBuf;

    }
}
