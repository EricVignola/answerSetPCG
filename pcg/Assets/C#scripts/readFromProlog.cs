using UnityEngine;
using System.Collections;
using System.Text;
using System.IO;

public class readFromProlog : MonoBehaviour {

    public string pathToFile;
    string[] section;

	// Use this for initialization
	void Start () {
        ReadFromFile();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void ReadFromFile() {
        StreamReader reader = new StreamReader("Assets/C#scripts/test.txt");

        string s = reader.ReadLine();
        char delimiter = ',';
        section = s.Split(delimiter);
        //char delimiter = ',';
        //section = s.Split(delimiter);
        //while (s != null) {
            //char[] delimiter = { ',' };
            //section = s.Split(delimiter);
            //s = reader.ReadLine();
        //}
        Debug.Log(section[1]);
    }
}
