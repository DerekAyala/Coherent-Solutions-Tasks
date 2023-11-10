using System;

namespace Task_2._3
{
    public class Lecture : Lesson, ICloneable
    {
        private String topic;

        public Lecture(String textDescription) : base(textDescription)
        {
        }

        public Lecture(String topic, String textDescription) : base(textDescription)
        {
            Topic = topic;
        }

        public String Topic
        {
            get { return topic; }
            set { topic = value; }
        }

        public object Clone()
        {
            Lecture clonedLecture = new Lecture(Topic, TextDescription);
            return clonedLecture;
        }
    }
}

