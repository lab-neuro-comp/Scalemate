using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScalemateProject.Model
{
    public class Group
    {
        private int _minimumValue;
        private int _maximumValue;
        private string _description;

        public Group(String description, int minimumValue, int maximumValue)
        {
            this._description = description;
            this._minimumValue = minimumValue;
            this._maximumValue = maximumValue;
        }

        public int minimumValue
        {
            get
            {
                return _minimumValue;
            }
            set
            {
                _minimumValue = value;
            }
        }

        public int maximumValue
        {
            get
            {
                return this._maximumValue;
            }
            set
            {
                _maximumValue = value;
            }
        }

        public string description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        public static Group createGroupFromJson(String json)
        {
            Group group = JsonConvert.DeserializeObject<Group>(json);

            return group;
        }
    }
}
