using System;
namespace Task_2._3
{
	public class PracticalLesson
	{
        private String textDescription;
        private String linkTaskCondition;
        private String linkSolution;
        public PracticalLesson()
		{
		}

        public PracticalLesson(String textDescription)
        {
            TextDescription = textDescription;
        }

        public PracticalLesson(String textDescription,String linkTaskCondition, String linkSolution)
        {
            TextDescription = textDescription;
            LinkSolution = linkSolution;
            LinkTaskCondition = linkTaskCondition;
        }

        public String TextDescription
        {
            get { return textDescription; }
            set { textDescription = value; }
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
    }
}

