using System;
namespace Task_2._3
{
    public class PracticalLesson : Lesson
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

        public override object Clone()
        {
            return new PracticalLesson(TextDescription, linkTaskCondition, LinkTaskCondition);
        }
    }
}

