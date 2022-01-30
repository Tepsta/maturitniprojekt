using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//Autor scriptu = Brackeys https://www.youtube.com/channel/UCYbK_tjZ2OrIZFBvU6CCMiA
public static class SaveSystem
{
    public static void SavePlayer(Player player, Inventory inventory)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.ayo";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(player, inventory);

        formatter.Serialize(stream, data);
        stream.Close();
    }
    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.ayo";
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
            Debug.LogError("Save file not found in: " + path);
            return null;
        }
    }
}
