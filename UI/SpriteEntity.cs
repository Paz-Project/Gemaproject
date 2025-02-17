﻿using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace GameLib
{
    public class SpriteEntity : Sprite, Entity
    {

        private ParentImpl parentImpl;


        public SpriteEntity(Texture texture) : base(texture)
        {
        }

        public SpriteEntity(Texture texture, IntRect rectangle) : base(texture, rectangle)
        {
        }

        public SpriteEntity()
        {
        }

        public Entity? Parent { get { return parentImpl.Parent; } }
        public void _NotifyParentAdded(Entity parent)
        {
            parentImpl._NotifyParentAdded(parent);
        }
        public void _NotifyParentRemoved()
        {
            parentImpl._NotifyParentRemoved();
        }
        public void Detach()
        {
            parentImpl.Detach(this);
        }
        public Transform GlobalTransform { get { return parentImpl.CalcGlobalTransform(this.Transform); } }

        public virtual void FrameUpdate(float deltaTime)
        {
        }

        public virtual void KeyPressed(KeyEventArgs e)
        {
        }

        public virtual void KeyReleased(KeyEventArgs e)
        {
        }

        public virtual void MouseButtonPressed(MouseButtonEventArgs e)
        {
        }

        public virtual void MouseButtonReleased(MouseButtonEventArgs e)
        {
        }

        public virtual void MouseMoved(MouseMoveEventArgs e)
        {
        }

        public virtual void MouseWheelScrolled(MouseWheelScrollEventArgs e)
        {
        }

        public virtual void PhysicsUpdate(float fixTime)
        {
        }

        public virtual void TextEntered(TextEventArgs e)
        {
        }
    }
}
