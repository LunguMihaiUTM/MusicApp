﻿using System.IO;

namespace MusicApp.BusinessLogic.Migrations.SongContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTestSong : DbMigration
    {
        public override void Up()
        {
            // Calea absolută către fișierul MP3 și imagine
            string mp3FilePath = @"C:\Users\lungu\Desktop\UTM\Anul 2\Proiect de An\MusicApp\MusicApp.Web\Vendor\audio\testAudio.mp3";
            string imageFilePath = @"C:\Users\lungu\Desktop\UTM\Anul 2\Proiect de An\MusicApp\MusicApp.Web\Vendor\images\music\r_music1.jpg";

            // Asigură-te că înlocuiești "PathToFolder" cu calea corectă către folderul care conține fișierele

            // Citește conținutul fișierului MP3 și al imaginii
            byte[] mp3FileData = File.ReadAllBytes(mp3FilePath);
            byte[] imageData = File.ReadAllBytes(imageFilePath);

            // Conversie la format hex pentru a putea insera datele binare prin SQL brut
            string mp3FileHex = BitConverter.ToString(mp3FileData).Replace("-", "");
            string imageHex = BitConverter.ToString(imageData).Replace("-", "");

            Sql($@"
                INSERT INTO SongTables (Title, Artist, Mp3File, Mp3FileName, Image, ImageFileName)
                VALUES (
                    'Test Song',
                    'Test Artist',
                    0x{mp3FileHex},
                    'testaudio.mp3',
                    0x{imageHex},
                    'testimage.jpg'
                )
            ");
        }

        public override void Down()
        {
            Sql("DELETE FROM Songs WHERE Title = 'Test Song' AND Artist = 'Test Artist'");
        }
    }
}