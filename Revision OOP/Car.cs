using System;
using System.Collections.Generic;
using System.Text;

namespace Revision_OOP
{
    class Car
    {
        #region Attributes
        private int id; // 4 Byte
        private string? model; // 4 Byte
        private double speed; // 8 Byte
        #endregion

        #region Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string? Model
        {
            get { return model; }
            set { model = value; }
        }
        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        #endregion


        // if u defined a constructor 
        // compiler will no longer Generate "Empty Parameterless Constructor"


        public Car(int id , string? model, double speed)
        {
            this.id = id;
            this.model = model;
            this.speed = speed;
        }

        #region Methods

        public override string ToString()
        {
            return $"Id = {id} \nModel= {model} \nSpead{speed}";
        }
        #endregion



    }
}
