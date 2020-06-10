using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrexRunner.Graphics {
    public class SpriteAnimation {

        private List<SpriteAnimationFrame> _frames = new List<SpriteAnimationFrame>();

        public SpriteAnimationFrame this[int index] {
            get {
                return GetFrame(index);
            }
        }

        public bool IsPlaying { get; private set; }

        public float PlaybackProgress { get; private set; }

        public void AddFrame(Sprite sprite, float timeStamp) {

            SpriteAnimationFrame frame = new SpriteAnimationFrame(sprite, timeStamp);

            _frames.Add(frame);

            SpriteAnimation anim = new SpriteAnimation();
            //add a couple of frames

            anim.GetFrame(1);

        }

        public void Update(GameTime gameTime) {

        }

        public void Play() {

            IsPlaying = true;


        }

        public void Stop() {

            IsPlaying = false;

        }

        public SpriteAnimationFrame GetFrame(int index) {

            if (index < 0 || index >= _frames.Count)
                throw new ArgumentOutOfRangeException(nameof(index), "A frame with index " + index + "does not exist in this animation.");

            return _frames[index];
        }
    }
}
