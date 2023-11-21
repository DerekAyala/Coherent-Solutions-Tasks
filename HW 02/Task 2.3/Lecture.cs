using System;

namespace Task_2._3
{
    public class Lecture : Lesson
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

        public override object Clone()
        {
            return new Lecture(Topic, TextDescription);
        }
    }
}

