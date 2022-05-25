using System;

namespace TemplateMethod
{
    abstract class Human
    {
        protected abstract void PutOnFootwear();
        protected abstract void PutOnBottom();
        protected abstract void PutOnTop();

        // template method
        public void Dress()
        {
            PutOnFootwear();
            PutOnBottom();
            PutOnTop();
        }
    }
}
