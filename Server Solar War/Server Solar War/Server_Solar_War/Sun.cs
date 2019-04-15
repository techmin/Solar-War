﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.IO;


namespace Server_Solar_War
{
    class Sun
    {
        private Texture2D display;
        private Texture2D[] img;
        private Rectangle rect;
        private int radiusH;
        

        public Sun()
        {
            rect = new Rectangle(200, 0, 100, 100);
            radiusH = 20;

            //change the radius 
        }

        public ContentManager Content
        {

            get { return content; }
        }
        ContentManager content;


    public void Load(IServiceProvider server)
        {
            content = new ContentManager(server, "Content");
            img = new Texture2D[2];
            img[0] = content.Load<Texture2D>("Sun/sun");
            img[1] = content.Load<Texture2D>("Sun/sun2");
                    
        }
    }
}
