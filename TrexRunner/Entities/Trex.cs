using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
//using SharpDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.Text;
using TrexRunner.Graphics;

namespace TrexRunner.Entities {
    public class Trex : IGameEntity {

        private const int TREX_IDLE_BACKGROUNG_SPRITE_POS_X = 40;
        private const int TREX_IDLE_BACKGROUNG_SPRITE_POS_Y = 0;

        public const int TREX_DEFAULT_SPRITE_POS_X = 848;
        public const int TREX_DEFAULT_SPRITE_POS_Y = 0;
        public const int TREX_DEFAULT_SPRITE_WIDTH = 44;
        public const int TREX_DEFAULT_SPRITE_HEIGHT = 52;

        private Sprite _idleBackgroundSprite;

        public Sprite Sprite { get; private set; }

        public TrexState State { get; private set; }

        public Vector2 Position { get; set; }

        public bool isAlive { get; private set; }

        public float Speed { get; private set; }

        public int DrawOrder { get; set; }

        public Trex(Texture2D spriteSheet, Vector2 position) {

            Sprite = new Sprite(spriteSheet, TREX_DEFAULT_SPRITE_POS_X, TREX_DEFAULT_SPRITE_POS_Y, TREX_DEFAULT_SPRITE_WIDTH, TREX_DEFAULT_SPRITE_HEIGHT);
            Position = position;
            _idleBackgroundSprite = new Sprite(spriteSheet, TREX_IDLE_BACKGROUNG_SPRITE_POS_X, TREX_IDLE_BACKGROUNG_SPRITE_POS_Y, TREX_DEFAULT_SPRITE_WIDTH, TREX_DEFAULT_SPRITE_HEIGHT);
            State = TrexState.Idle;
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime) {
            if(State == TrexState.Idle) {
                _idleBackgroundSprite.Draw(spriteBatch, Position);
            }

            Sprite.Draw(spriteBatch, this.Position);
        }

        public void Update(GameTime gameTime) {
        }
    }
}
