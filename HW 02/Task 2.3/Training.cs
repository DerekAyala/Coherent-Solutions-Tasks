using System;
using System.Xml.Linq;

namespace Task_2._3
{
    public class Training
    {
        private String textDescription;
        private object[] set = new object[1];

        public Training()
        {
        }

        public Training(String textDescription)
        {
            TextDescription = textDescription;
        }

        public String TextDescription
        {
            get { return textDescription; }
            set { textDescription = value; }
        }

        public void Add(object obj)
        {
            object[] newSet = new object[set.Length + 1];
            for (int i = 0; i < set.Length; i++)
            {
                newSet[i] = set[i];
            }
            newSet[set.Length] = obj;
            set = newSet;
        }

        public Boolean IsPractical()
        {
            foreach (var item in set)
            {
                if (!(item is PracticalLesson) || item == null)
                {
                    return false;
                }
            }
            return true;
        }

        public object Clone()
        {
            Training clonedTraining = new Training();
            clonedTraining.TextDescription = textDescription;
            clonedTraining.set = new object[this.set.Length];
            foreach(var item in set)
            {
                if (item is Lecture lecture)
                {
                    clonedTraining.Add(new Lecture(lecture.TextDescription, lecture.Topic));
                }
                else if (item is PracticalLesson practical)
                {
                    clonedTraining.Add(new PracticalLesson(practical.TextDescription, practical.LinkTaskCondition, practical.LinkSolution));
                }
            }
            return clonedTraining;
        }
    }
}

