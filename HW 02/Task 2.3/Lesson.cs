using System;
namespace Task_2._3
{
	public class Lesson
	{
        private String textDescription;

        public Lesson(String textDescription)
		{
			TextDescription = textDescription;
		}

		public String TextDescription
		{
			get { return textDescription; }
			set { textDescription = value; }
		}

	}
}

