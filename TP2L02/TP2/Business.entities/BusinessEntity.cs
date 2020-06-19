﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class BusinessEntity
    {
        public enum States
        {
            Deleted,
            New,
            Modified,
            Unmodified
        }

        private States _State;
        public States State
        {
            get { return _State; }
            set { _State = value; }
        }
        private int _ID;
        public int ID { get => _ID; set => _ID = value; }

        public BusinessEntity()
        {
            this.State = States.New;
        }

    }
}
