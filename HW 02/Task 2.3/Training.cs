namespace Task_2._3
{
    public class Training : ICloneable
    {
        private String textDescription;
        private Lesson[] _lessons = new Lesson[1];

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

        public void Add(Lesson obj)
        {
            Lesson[] newLessons = new Lesson[_lessons.Length + 1];
            for (int i = 0; i < _lessons.Length; i++)
            {
                newLessons[i] = _lessons[i];
            }
            newLessons[_lessons.Length] = obj;
            _lessons = newLessons;
        }

        public Boolean IsPractical()
        {
            foreach (var item in _lessons)
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
            clonedTraining._lessons = new Lesson[this._lessons.Length];
            foreach (var item in _lessons)
            {
                clonedTraining.Add((Lesson)item.Clone());
            }
            return clonedTraining;
        }
    }
}

