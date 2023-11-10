using System;
namespace Task_2._3
{
    public class PracticalLesson : Lesson, ICloneable
    {
        private String linkTaskCondition;
        private String linkSolution;
        public PracticalLesson(String textDescription) : base(textDescription)
        {
        }


        public PracticalLesson(String textDescription, String linkTaskCondition, String linkSolution) : base(textDescription)
        {
            LinkSolution = linkSolution;
            LinkTaskCondition = linkTaskCondition;
        }

        public String LinkTaskCondition
        {
            get { return linkTaskCondition; }
            set { linkTaskCondition = value; }
        }

        public String LinkSolution
        {
            get { return linkSolution; }
            set { linkSolution = value; }
        }

        public object Clone()
        {
            PracticalLesson clonedLecture = new PracticalLesson(TextDescription, linkTaskCondition, LinkTaskCondition);
            return clonedLecture;
        }
    }
}

