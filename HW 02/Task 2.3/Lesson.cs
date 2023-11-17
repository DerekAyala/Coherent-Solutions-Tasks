using System;

namespace Task_2._3
{
    public class Lesson: ICloneable
    {
        private string _textDescription;

        public Lesson(string textDescription)
        {
            TextDescription = textDescription;
        }

        public string TextDescription
        {
            get { return _textDescription; }
            set { _textDescription = value; }
        }

        public object Clone()
        {
            return new Lesson(TextDescription);
        }
    }
}

