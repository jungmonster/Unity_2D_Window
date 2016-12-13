using UnityEngine;
using System.Collections;
using System.IO;

public class FileData : DP_Singleton<FileData> {

    DP_Observer fileObserver;
    private string FileName;
    public string workPath;
    public string filePath;
    FileStream fileStream;
    public string fileName
    {
        get
        {
            return FileName;
        }
        set
        {
            FileName = value;
        }
    }

    public string strBuf;

    public GameObject contentPanel;


    void Start () {
        fileObserver = new DP_Observer();
        workPath = filePath = fileName = strBuf = null;
        workPath = Application.dataPath;

        AttachCallMember();

        TestCaller();
    }

    void TestCaller()
    {
        Debug.Log(workPath);

        CreateFile("test22.txt");
        WriteFileContent("AAAAAAAA");
        OpenFile();
        ReadFileContent();
        fileObserver.FileChangeCall();
    }

    void AttachCallMember()
    {
        fileObserver.FileChangeCallAttach(contentPanel.GetComponent<M_ContentPanel>());
    }


    public void CreateFile(string _fileName)
    {
        fileName = _fileName;
        filePath = workPath + "/" + fileName;
        if(fileStream != null)
        {
            fileStream = null;
        }
        fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
    }

    public void OpenFile()
    {
        if (fileStream != null)
        {
            fileStream = null;
        }
        fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
    }

    public string GetFileName()
    {
        return fileName;
    }

    public void WriteFileContent(string str)
    {
        StreamWriter writer = new StreamWriter(fileStream);
        writer.WriteLine(str);
        writer.Close();
    }

    public string ReadFileContent()
    {
        StreamReader reader = new StreamReader(fileStream);
        strBuf = reader.ReadToEnd();
        reader.Close();
        return strBuf;
    }
    
	
}
