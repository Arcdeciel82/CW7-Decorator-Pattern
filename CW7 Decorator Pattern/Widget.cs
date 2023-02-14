using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CW7_Decorator_Pattern
{
    internal interface Widget
    {
        void draw();
    }

    class TextField : Widget
    {
        private int width, height;

        public TextField(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void draw()
        {
            Console.WriteLine("I am a TextField Widget of width " + width + " and height " + height + ".");
        }
    }

    abstract class Decorator : Widget
    {
        private Widget wid;
        
        public virtual void draw()
        {
            wid.draw();
        }
        
        public Decorator(Widget w)
        {
            wid = w;
        }
    }

    class BorderDecorator : Decorator
    {
        public BorderDecorator(Widget w) : base(w)
        {
        }

        public override void draw()
        {
            Console.WriteLine("I am a BorderDecorator holding a: ");
            base.draw();
        }
    }

    class ScrollDecorator : Decorator
    {
        public ScrollDecorator(Widget w) : base(w)
        {
        }

        public override void draw()
        {
            Console.WriteLine("I am a ScrollDecorator holding a: ");
            base.draw();
        }
    }
}
