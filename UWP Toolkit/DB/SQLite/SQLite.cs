using Microsoft.Data.Sqlite;
using SQLitePCL;
using System;
using System.Threading.Tasks;
using Windows.Storage;

namespace UWP_Toolkit.DB.SQLite;

public static class SQLite
{
    public async static Task Initialize(string dbName, string[] tableCommands)
    {
        Batteries.Init();
        await ApplicationData.Current.LocalFolder.CreateFileAsync(dbName, CreationCollisionOption.OpenIfExists);
        using SqliteConnection db = new($"Filename={dbName}");
        db.Open();
        for (int i = 0; i < tableCommands.Length; i++)
        {
            SqliteCommand createTable = new(tableCommands[i], db);
            createTable.ExecuteReader();
        }
        db.Close();
    }

    public async static Task Initialize(string dbName, string[] paths, string[] tableCommands)
    {
        Batteries.Init();
        await ApplicationData.Current.LocalFolder.CreateFileAsync(dbName, CreationCollisionOption.OpenIfExists);
        for (int i = 0; i < paths.Length; i++)
        {
            await ApplicationData.Current.LocalFolder.CreateFileAsync(paths[i], CreationCollisionOption.OpenIfExists);
        }
        using SqliteConnection db = new($"Filename={dbName}");
        db.Open();
        for (int i = 0; i < tableCommands.Length; i++)
        {
            SqliteCommand createTable = new(tableCommands[i], db);
            createTable.ExecuteReader();
        }
        db.Close();
    }
}
