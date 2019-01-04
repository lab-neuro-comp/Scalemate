using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScalemateProject.Model
{
    class Participant
    {
        private string _name;
        private List<Result> _entries;
        
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        public List<Result> entries
        {
            get
            {
                return this._entries;
            }
            set
            {
                this._entries = value; 
            }
        }

        public static Participant createParticipantFromJson(String json)
        {
            Participant participant = JsonConvert.DeserializeObject<Participant>(json);

            return participant;
        }
    }
}
