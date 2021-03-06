﻿using HammerModel.Helpers;
using HammerModel.Model.Textures;
using HammerModel.Model.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HammerModel.Model
{
    public class Solid : HammerObject
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public Side Side1 { get; set; }
        public Side Side2 { get; set; }
        public Side Side3 { get; set; }
        public Side Side4 { get; set; }
        public Side Side5 { get; set; }
        public Side Side6 { get; set; }
        public Editor Editor { get; set; }

        public Solid(double x, double y, double z, double width, double breadth, double height, BlockTexture textureInfo = null)
        {
            if (textureInfo == null)
            {
                textureInfo = BlockTexture.GetDefault();
            }

            X = x;
            Y = y;
            Z = z;
            Editor = Editor.GetDefault();
            Side1 = new Side
            {
                Plane = new CoordinateTriple
                {
                    X1 = x,
                    Y1 = y,
                    Z1 = z + height,
                    X2 = x,
                    Y2 = y + breadth,
                    Z2 = z + height,
                    X3 = x + width,
                    Y3 = y + breadth,
                    Z3 = z + height,
                    Rotations = Rotations
                },
                Material = textureInfo.TopTexture,
                UAxis = new Axis
                {
                    X = 1,
                    Y = 0,
                    Z = 0,
                    Translation = 0,
                    Factor = 0.25,
                    Rotations = Rotations
                },
                VAxis = new Axis
                {
                    X = 0,
                    Y = -1,
                    Z = 0,
                    Translation = 0,
                    Factor = 0.25,
                    Rotations = Rotations
                },
                Rotation = 0,
                LightMapScale = 16,
                Smoothing_Groups = 0
            };
            Side2 = new Side
            {
                Plane = new CoordinateTriple
                {
                    X1 = x,// + size,
                    Y1 = y + breadth,
                    Z1 = z,// + size,
                    X2 = x,// + size,
                    Y2 = y,// + size,
                    Z2 = z,// + size,
                    X3 = x + width,
                    Y3 = y,// + size,
                    Z3 = z,// + size,
                    Rotations = Rotations
                },
                Material = textureInfo.TopTexture,
                UAxis = new Axis
                {
                    X = 1,
                    Y = 0,
                    Z = 0,
                    Translation = 0,
                    Factor = 0.25,
                    Rotations = Rotations
                },
                VAxis = new Axis
                {
                    X = 0,
                    Y = -1,
                    Z = 0,
                    Translation = 0,
                    Factor = 0.25,
                    Rotations = Rotations
                },
                Rotation = 0,
                LightMapScale = 16,
                Smoothing_Groups = 0
            };
            Side3 = new Side
            {
                Plane = new CoordinateTriple
                {
                    X1 = x,// + size,
                    Y1 = y,// + size,
                    Z1 = z,// + size,
                    X2 = x,// + size,
                    Y2 = y + breadth,
                    Z2 = z,// + size,
                    X3 = x,// + size,
                    Y3 = y + breadth,
                    Z3 = z + height,
                    Rotations = Rotations
                },
                Material = textureInfo.DefaultTexture,
                UAxis = new Axis
                {
                    X = 0,
                    Y = 1,
                    Z = 0,
                    Translation = 0,
                    Factor = 0.25,
                    Rotations = Rotations
                },
                VAxis = new Axis
                {
                    X = 0,
                    Y = 0,
                    Z = -1,
                    Translation = 0,
                    Factor = 0.25,
                    Rotations = Rotations
                },
                Rotation = 0,
                LightMapScale = 16,
                Smoothing_Groups = 0
            };
            Side4 = new Side
            {
                Plane = new CoordinateTriple
                {
                    X1 = x + width,
                    Y1 = y + breadth,
                    Z1 = z,// + size,
                    X2 = x + width,
                    Y2 = y,// + size,
                    Z2 = z,// + size,
                    X3 = x + width,
                    Y3 = y,// + size,
                    Z3 = z + height,
                    Rotations = Rotations
                },
                Material = textureInfo.DefaultTexture,
                UAxis = new Axis
                {
                    X = 0,
                    Y = 1,
                    Z = 0,
                    Translation = 0,
                    Factor = 0.25,
                    Rotations = Rotations
                },
                VAxis = new Axis
                {
                    X = 0,
                    Y = 0,
                    Z = -1,
                    Translation = 0,
                    Factor = 0.25,
                    Rotations = Rotations
                },
                Rotation = 0,
                LightMapScale = 16,
                Smoothing_Groups = 0
            };
            Side5 = new Side
            {
                Plane = new CoordinateTriple
                {
                    X1 = x,// + size,
                    Y1 = y + breadth,
                    Z1 = z,// + size,
                    X2 = x + width,
                    Y2 = y + breadth,
                    Z2 = z,// + size,
                    X3 = x + width,
                    Y3 = y + breadth,
                    Z3 = z + height,
                    Rotations = Rotations
                },
                Material = textureInfo.DefaultTexture,
                UAxis = new Axis
                {
                    X = 1,
                    Y = 0,
                    Z = 0,
                    Translation = 0,
                    Factor = 0.25,
                    Rotations = Rotations
                },
                VAxis = new Axis
                {
                    X = 0,
                    Y = 0,
                    Z = -1,
                    Translation = 0,
                    Factor = 0.25,
                    Rotations = Rotations
                },
                Rotation = 0,
                LightMapScale = 16,
                Smoothing_Groups = 0
            };
            Side6 = new Side
            {
                Plane = new CoordinateTriple
                {
                    X1 = x + width,
                    Y1 = y,// + size,
                    Z1 = z,// + size,
                    X2 = x,// + size,
                    Y2 = y,// + size,
                    Z2 = z,// + size,
                    X3 = x,// + size,
                    Y3 = y,// + size,
                    Z3 = z + height,
                    Rotations = Rotations
                },
                Material = textureInfo.DefaultTexture,
                UAxis = new Axis
                {
                    X = 1,
                    Y = 0,
                    Z = 0,
                    Translation = 0,
                    Factor = 0.25,
                    Rotations = Rotations
                },
                VAxis = new Axis
                {
                    X = 0,
                    Y = 0,
                    Z = -1,
                    Translation = 0,
                    Factor = 0.25,
                    Rotations = Rotations
                },
                Rotation = 0,
                LightMapScale = 16,
                Smoothing_Groups = 0
            };
        }

        public override string ToString()
        {
            return HONHelper.GetHonObjectBody("solid",
                HONHelper.GetKeyValuePair("id", Id),
                Side1.ToString(),
                Side2.ToString(),
                Side3.ToString(),
                Side4.ToString(),
                Side5.ToString(),
                Side6.ToString(),
                Editor.ToString());
        }
    }
}
