namespace OOStepByStep
{
    public class Teacher : Person
    {
        private Class classClass;
        public Teacher(string name, int age) : base(name, age)
        {
        }

        public void SetClass(Class classClass)
        {
            this.classClass = classClass;
        }

        public new string Introduce()
        {
            if (classClass != null)
            {
                return base.Introduce() + $" I am a teacher of {classClass.GetName()}.";
            }

            return base.Introduce() + " I am a teacher.";
        }
    }
}