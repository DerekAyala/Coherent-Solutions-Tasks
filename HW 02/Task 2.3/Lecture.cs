using System;
using System.Xml.Linq;

namespace Task_2._3
{
	public class Lecture
	{
        private String textDescription;
        private String topic;

        public Lecture()
		{
		}

        public Lecture(String topic)
        {
            Topic = topic;
        }

        public Lecture(String topic, String textDescription)
        {
            Topic = topic;
            TextDescription = textDescription;
        }

        public String TextDescription
        {
            get { return textDescription; }
            set { textDescription = value; }
        }

        public String Topic
        {
            get { return topic; }
            set { topic = value; }
        }
    }
}

