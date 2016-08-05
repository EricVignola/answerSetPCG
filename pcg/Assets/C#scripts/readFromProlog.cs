using UnityEngine;
using System.Collections;
using System.Text;
using System.IO;

public class readFromProlog : MonoBehaviour {

    public string pathToFile;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        ReadFromFile();
	
	}

    private void ReadFromFile() {
        StreamReader reader = new StreamReader("Assets/C#scripts/test.txt");

        string s = reader.ReadLine();
        Debug.Log(s);
    }
}
