using UnityEngine;
using System.Collections;
using System.IO;

public class FileData : DP_Singleton<FileData> {

    DP_Observer fileObserver;
    private string FileName;
    public string workPath;
    public string filePath;


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

        GetFileList();
        //TestCaller();
    }

    void TestCaller()
    {
        Debug.Log(workPath);

        CreateFile("test22.txt");
        WriteFileContent("AAAAAAAA");
        OpenFile();
        //ReadFileContent();
        fileObserver.FileChangeCall();
    }


    // add observer object 
    void AttachCallMember()
    {
        fileObserver.FileChangeCallAttach(contentPanel.GetComponent<M_ContentPanel>());
    }


    public void CreateFile(string _fileName)
    {
        FileStream fileStream;
        fileName = _fileName;
        filePath = workPath + "/" + fileName;
        fileStream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite);
        strBuf = "";
        fileStream.Close();
        fileObserver.FileChangeCall();
    }

    public void OpenFile()
    {
        FileStream fileStream;
        fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);

    }

    public string GetFileName()
    {
        return fileName;
    }

    public void WriteFileContent(string str)
    {
        Debug.Log("data : " + str);

        StreamWriter writer = new StreamWriter(filePath);
        writer.WriteLine(str);

        writer.Close();
    }

    public string ReadFileContent(string filePath)
    {
        Debug.Log(filePath);
        StreamReader reader = new StreamReader(filePath);
        strBuf = reader.ReadToEnd();
        Debug.Log(strBuf);
        reader.Close();
        fileObserver.FileChangeCall();
        return strBuf;
    }

    public void GetFileList()
    {
        DirectoryInfo dir = new DirectoryInfo(workPath);
        FileInfo[] files = dir.GetFiles("*.txt");
        if(files.Length != 0)
        {
            foreach(FileInfo file in files)
            {
                Debug.Log(file.Name.ToString());
            }
        }
    }
    
	
}
