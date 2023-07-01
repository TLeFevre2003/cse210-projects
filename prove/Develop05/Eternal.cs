namespace Develop05
{
    class Eternal : Goal
    {

        public Eternal(string name, string description, int point_value) : base(name,description,point_value)
        {
        }
        public override int GetPoints()
        {
            return base._point_value;
        }
        public override string GetRepresentation()
        {
            return $"Eternal-{base.GetName()}-{base.GetDescription()}-{GetPoints().ToString()}";
        }
        public override string Display()
        {
            return $"[ ] {_name} ({_description})";
            
        }

    }
}