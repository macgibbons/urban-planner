using System;

namespace Planner
{
    public class Building
    {
        private string _designer = "Mac Gibbons";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }
        public string Descrition
        {
            get
            {
                return $@"
                {_address}
                ------------
                Designed by  {_designer}
                Constructed on {_dateConstructed}
                Owned by {_owner}
                {Volume} cubic meters of space";
            }
        }

        public Building (string address)
        {
            _address = address;
        }

        public void Construct ()
        {
            _dateConstructed = DateTime.Now;
        }
        public void Purchase (string Name)
        {
            _owner = Name;
        }

    }

}