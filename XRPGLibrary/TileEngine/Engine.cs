using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This class stores the tile width and height. We also have a helper function to convert an x,y position into a tile point on the map. 

namespace XRPGLibrary.TileEngine
{
    public class Engine
    {
        #region Field Region
        static int tileWidth;
        static int tileHeight;
        #endregion
        #region Property Region
        public static int TileWidth
        {
            get { return tileWidth; }
        }
        public static int TileHeight
        {
            get { return tileHeight; }
        }
        #endregion
        #region Constructors
        public Engine(int tileWidth, int tileHeight)
        {
            Engine.tileWidth = tileWidth;
            Engine.tileHeight = tileHeight;
        }
        #endregion
        #region Methods
        public static Point VectorToCell(Vector2 position)
        {
            return new Point((int)position.X / tileWidth, (int)position.Y / tileHeight);
        }
        #endregion
    }
}
