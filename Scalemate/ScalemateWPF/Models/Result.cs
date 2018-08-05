using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScalemateWPF.Models
{
    class Result
    {
        private Scale _scale;
        private Queue<int> _answers;
        private DateTime _dateTime;

        public Scale scale
        {
            get
            {
                return this._scale;
            }
            set
            {
                this._scale = value;
            }
        }
        public Queue<int> answers
        {
            get
            {
                return this._answers;
            }
            set
            {
                this._answers = value;
            }
        }
        public DateTime dateTime
        {
            get
            {
                return this._dateTime;
            }
            set
            {
                this._dateTime = value;
            }
        }

        public void addSingleAnswer(int answer)
        {
            this._answers.Enqueue(answer);
        }

        public static Result createResultFromJson(String json)
        {
            Result result = JsonConvert.DeserializeObject<Result>(json);

            return result;
        }
    }
}
