﻿using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcyMazeRunner.Klassen
{
    
        public enum EGameStates
        {
            none,
            mainMenu,
            credits,
            controls,
            inGame,
            gameWon,

        }

        interface GameStates
        {
            void initialize();

            void loadContent();

            EGameStates update(GameTime time);

            void draw(RenderWindow win);
        }


    
}
