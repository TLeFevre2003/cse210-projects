namespace Develop05
{
    class Simple : Goal
    {
        private bool _complete;
        
        public Simple(string name, string description, int point_value, bool complete) : base(name,description,point_value)
        {
            _complete = complete;


        }
        public override int GetPoints()
        {
            _complete = true;
            return base._point_value;
        }
        public override string GetRepresentation()
        {
            return $"Simple-{base.GetName()}-{base.GetDescription()}-{GetPoints().ToString()}-{_complete.ToString()}";
        }
        public override string Display()
        {
            if (_complete)
            {
               return $"[X] {_name} ({_description})";
            }
            return $"[ ] {_name} ({_description})";
            
        }



    }



}