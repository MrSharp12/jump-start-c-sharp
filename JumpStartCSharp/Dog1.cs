using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpStartCSharp
{
    public class Trainer
    {
        void Operate()
        {
            var dog = new Poodle();
            dog.HasSpoken += Dog_HasSpoken;
        }

        private void Dog_HasSpoken(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }

    public partial class Dog
    {
        //properties hold values
        public int Age { get; set; }

        private string _name;

        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }

        public void Speak(string what = "bark")//bark is the default
        {
            //TODO
        }


        //event
        //events are a way that a class or object can talk back to me
        //EventHandler defines the shape of the method that the event expects to be handling when you raise it
        public event EventHandler HasSpoken;

        //overload
        public void Speak(int times, string what = "bark", bool sit = true)//bark is the default
        {
            //TODO
            //event has been raised
            if (HasSpoken != null) //nobody has subscribed to it, ex of publish/subscribe pattern
            HasSpoken(this, EventArgs.Empty);
        }

        //only by this class
        private void Foo() { }

        //only by this and the inherited class
        protected void Gulp() { }

        //only in this assembly
        internal void Bar() { }
    }

    class Poodle : Dog
    {
        void x()
        {
            this.Speak(2, sit: true);
        }
    }
}
