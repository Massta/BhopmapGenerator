﻿using HammerModel.Model;
using HammerModel.Model.Misc;
using HammerModel.Model.Structures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BhopmapGenerator
{ 
    public class BhopGenerator
    {
        private TextureInfo StandardWall;
        private TextureInfo StandardFloor;
        private TextureInfo StandardCeiling;
        public BhopGenerator()
        {
            StandardCeiling = new TextureInfo
            {
                TopTexture = "dev/graygrid",
                SideTexture = "dev/graygrid"
            };
            StandardFloor = new TextureInfo
            {
                TopTexture = "dev/dev_measuregeneric01",
                SideTexture = "dev/dev_measuregeneric01"
            };
            StandardWall = new TextureInfo
            {
                TopTexture = "dev/dev_measuregeneric01b",
                SideTexture = "dev/dev_measuregeneric01b"
            };
            Map m = new Map();
            Room r = new Room
            {
                X = 0,
                Y = 0,
                Z = 0,
                Width = 1024,
                Breadth = 512,
                Height = 256,
                CeilingTextureInfo = StandardCeiling,
                FloorTextureInfo = StandardFloor,
                WallTextureInfo = StandardWall
            };
            Room r2 = new Room
            {
                X = 0,
                Y = 0,
                Z = 256,
                Width = 4096,
                Breadth = 1024,
                Height = 128,
                CeilingTextureInfo = StandardCeiling,
                FloorTextureInfo = StandardFloor,
                WallTextureInfo = StandardWall
            };
            Teleport tp = new Teleport
            {
                X = 0,
                Y = 0,
                Z = 0,
                Width = 100,
                Breadth = 100,
                Height = 100,
                Target = "TelepORTererr"
            };

            Spawn t = new Spawn
            {
                Terrorist = true,
                X = 110,
                Y = 110,
                Z = 110
            };
            Spawn ct = new Spawn
            {
                Terrorist = false,
                X = 110,
                Y = 180,
                Z = 110
            };

            for(int i = 0; i < 10; i++)
            {
                WorldLight l = new WorldLight
                {
                    X = 110 + i * 100,
                    Y = 110,
                    Z = 230,
                    R = 255,
                    G = 255,
                    B = 255,
                    A = 200,
                };
                m.AddEntity(l);
            }

            m.AddEntity(t);
            m.AddEntity(ct);
            m.AddWorldObject(r);
            m.AddWorldObject(r2);
            m.AddEntity(tp);

            //for(int i = 0; i < 50; i++)
            //{
            //    Cuboid c = new Cuboid
            //    {
            //        X = i * 32,
            //        Y = i * 32,
            //        Z = i * 32,
            //        Width = i * 32,
            //        Breadth = i * 32,
            //        Height = i * 32
            //    };
            //    m.AddWorldObject(c); //TODO: Fehler mit der ID herausfinden
            //}

            Console.WriteLine(m.ToString());
            File.WriteAllText(@"F:\Program Files (x86)\Steam\steamapps\common\Counter-Strike Global Offensive\sdk_content\maps\generated.vmf", m.ToString());
        }
    }
}
