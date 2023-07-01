namespace Develop05
{
    abstract class Goal
    {
        protected string _name;
        protected string _description;
        protected int _point_value;

        public Goal (string name,string description,int point_value)
        {
            _name = name;
            _description = description;
            _point_value = point_value;



        }
        public abstract string GetRepresentation();
        public abstract int GetPoints();
        public abstract string Display();
        public string GetName()
        {
            return _name;
        }
        public string GetDescription()
        {
            return _description;
        }



    }





}