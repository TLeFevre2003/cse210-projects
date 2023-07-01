namespace Develop05;

    class Checklist : Goal
    {
        private int _completed;
        private int _wanted;
        private int _completionPoints;

        public Checklist(string name, string description, int point_value,int completed,int wanted,int completedPoints) : base(name,description,point_value)
        {
            _completed = completed;
            _wanted = wanted;
            _completionPoints = completedPoints;
        }
        public override int GetPoints()
        {
            _completed++;
            if (_wanted<_completed)
                return base._point_value;
            else
                return _completed;
            
        }
        public override string GetRepresentation()
        {
            return $"Checklist-{base.GetName()}-{base.GetDescription()}-{GetPoints().ToString()}-{_completed.ToString()}-{_wanted.ToString()}-{_completionPoints.ToString()}";
        }
        public override string Display()
        {
            if (_completed == _wanted)
            {
               return $"[X] {_name} ({_description}) -- Currently completed: {_completed}/{_wanted}";
            }
            return $"[ ] {_name} ({_description}) -- Currently completed: {_completed}/{_wanted}";
            
        }



    }
