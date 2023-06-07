using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

// Untuk metode JSON
// Class harus diberi Serializable untuk conversion JSON
// Memerlukan library System
// Class sebaiknya dipisah dalam file sendiri
[Serializable]
class Mahasiswa
{
    public string nim;
    public string name;
    public int exp;
}

// Agar array dapat diconvert ke JSON
class CollectionMahasiswa
{
    public Mahasiswa[] member;
}

public class SaveLoadSystem : MonoBehaviour
{
    // Membuat class
    CollectionMahasiswa cm = new CollectionMahasiswa();

    private void Start()
    {
        CreateDataDummy();
        //JSONSave();
        //JSONLoad();

        BinarySave();
    }

    public void BinarySave()
    {
        // (path name + extension, filemode yang digunakan)
        FileStream file = File.Open(Application.persistentDataPath + "dataBinary.BINUS", FileMode.OpenOrCreate);
        BinaryFormatter binaryFormatter = new BinaryFormatter();

        // Untuk convert serializable class menjadi binary
        binaryFormatter.Serialize(file, cm);
    }

    public void BinaryLoad()
    {
        if(File.Exists(Application.persistentDataPath + "dataBinary.BINUS"))
        {
            FileStream file = File.Open(Application.persistentDataPath + "dataBinary.BINUS", FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            cm = (CollectionMahasiswa)binaryFormatter.Deserialize(file);
        } else
        {
            BinarySave();
        }
        
    }

    public void CreateDataDummy()
    {
        // Call PlayerPref
        // PlayerPref hanya terbatas pada float, int dan string
        // Data disimpan dalam registry PC, jadi user dapat membaca dan mengubahnya

        // Set untuk menempatkan value di key
        // Kalau key belum ada, key baru akan dibuat
        // Kalau key sudah ada, value key akan di-overwrite
        //PlayerPrefs.SetFloat("sfxVolume", 1f);

        // Get untuk mengambil value dari key
        // Second parameter untuk default value, jika key tidak return value
        //PlayerPrefs.GetFloat("sfxVolume", 1f);

        cm.member = new Mahasiswa[5];

        cm.member[0] = new Mahasiswa();
        cm.member[0].nim = "2501001003";
        cm.member[0].name = "Joe Mama";
        cm.member[0].exp = 42069;

        cm.member[1] = new Mahasiswa();
        cm.member[1].nim = "2501001004";
        cm.member[1].name = "Joe Balls";
        cm.member[1].exp = 123456;

        
    }

    public void JSONSave()
    {
        // Convert class to JSON
        // Metode ini tidak menerima array
        string data = JsonUtility.ToJson(cm);

        // JSON String dapat di-write to file / PlayerPrefs
        // (nama key, variabel)
        PlayerPrefs.SetString("info", data);

        // Metode berasal dari vanilla C#
        // (path name + extension, data)
        File.WriteAllText(Application.persistentDataPath + "/data.BINUS", data);

        Debug.Log(data);
    }

    public void JSONLoad()
    {
        // Read data from file and convert to JSON string
        string data = File.ReadAllText(Application.persistentDataPath + "/data.BINUS");

        // Convert JSON string to serializable class
        JsonUtility.FromJson<CollectionMahasiswa>(data);
    }
}
