using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveSystem
{
    public static void SavePlayer(GameManager gameManager)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/gameManager.save";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(gameManager);

        formatter.Serialize(stream, data);
        stream.Close();

        Debug.Log("Схранено");
    }

    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/gameManager.save";
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not fpund in " + path);
            return null;
        }
    }

    public static void ResetPlayer()
    {
        string path = Application.persistentDataPath + "/gameManager.save";
        if(File.Exists(path))
        {
            File.Delete(path);
        }
        else
        {
            Debug.LogError("Reset file not fpund in " + path);
        }
    }

    //Сохраненка 1

    public static void SavePlayer1(GameManager gameManager)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/gameManager.save1";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(gameManager);

        formatter.Serialize(stream, data);
        stream.Close();

        Debug.Log("Схранено1");
    }

    public static PlayerData LoadPlayer1()
    {
        string path = Application.persistentDataPath + "/gameManager.save1";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not fpund in " + path);
            return null;
        }
    }

    public static void ResetPlayer1()
    {
        string path = Application.persistentDataPath + "/gameManager.save1";
        if (File.Exists(path))
        {
            File.Delete(path);
        }
        else
        {
            Debug.LogError("Reset file not fpund in " + path);
        }
    }

    //Сохраненка 2

    public static void SavePlayer2(GameManager gameManager)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/gameManager.save2";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(gameManager);

        formatter.Serialize(stream, data);
        stream.Close();

        Debug.Log("Схранено2");
    }

    public static PlayerData LoadPlayer2()
    {
        string path = Application.persistentDataPath + "/gameManager.save2";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not fpund in " + path);
            return null;
        }
    }

    public static void ResetPlayer2()
    {
        string path = Application.persistentDataPath + "/gameManager.save2";
        if (File.Exists(path))
        {
            File.Delete(path);
        }
        else
        {
            Debug.LogError("Reset file not fpund in " + path);
        }
    }

    //Сохраненка 3

    public static void SavePlayer3(GameManager gameManager)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/gameManager.save3";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(gameManager);

        formatter.Serialize(stream, data);
        stream.Close();

        Debug.Log("Схранено3");
    }

    public static PlayerData LoadPlayer3()
    {
        string path = Application.persistentDataPath + "/gameManager.save3";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not fpund in " + path);
            return null;
        }
    }

    public static void ResetPlayer3()
    {
        string path = Application.persistentDataPath + "/gameManager.save3";
        if (File.Exists(path))
        {
            File.Delete(path);
        }
        else
        {
            Debug.LogError("Reset file not fpund in " + path);
        }
    }

    //Сохраненка 4

    public static void SavePlayer4(GameManager gameManager)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/gameManager.save4";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(gameManager);

        formatter.Serialize(stream, data);
        stream.Close();

        Debug.Log("Схранено4");
    }

    public static PlayerData LoadPlayer4()
    {
        string path = Application.persistentDataPath + "/gameManager.save4";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not fpund in " + path);
            return null;
        }
    }

    public static void ResetPlayer4()
    {
        string path = Application.persistentDataPath + "/gameManager.save4";
        if (File.Exists(path))
        {
            File.Delete(path);
        }
        else
        {
            Debug.LogError("Reset file not fpund in " + path);
        }
    }

    //Сохраненка 5

    public static void SavePlayer5(GameManager gameManager)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/gameManager.save5";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(gameManager);

        formatter.Serialize(stream, data);
        stream.Close();

        Debug.Log("Схранено5");
    }

    public static PlayerData LoadPlayer5()
    {
        string path = Application.persistentDataPath + "/gameManager.save5";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not fpund in " + path);
            return null;
        }
    }

    public static void ResetPlayer5()
    {
        string path = Application.persistentDataPath + "/gameManager.save5";
        if (File.Exists(path))
        {
            File.Delete(path);
        }
        else
        {
            Debug.LogError("Reset file not fpund in " + path);
        }
    }


    public static void SavePlayer6(GameManager gameManager)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/gameManager.save6";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerIAP data = new PlayerIAP(gameManager);

        formatter.Serialize(stream, data);
        stream.Close();

        Debug.Log("Схранено6");
    }

    public static PlayerIAP LoadPlayer6()
    {
        string path = Application.persistentDataPath + "/gameManager.save6";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerIAP data = formatter.Deserialize(stream) as PlayerIAP;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not fpund in " + path);
            return null;
        }
    }

    public static void ResetPlayer6()
    {
        string path = Application.persistentDataPath + "/gameManager.save6";
        if (File.Exists(path))
        {
            File.Delete(path);
        }
        else
        {
            Debug.LogError("Reset file not fpund in " + path);
        }
    }
}
