using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSM_Lab1
{
    public class FSM
    {
        public enum State {b1, b2, b3, b4, b5 }; //состояния - b
        public enum Inputs { z1, z2, z3, z4 }; //входы -z
        public enum Exits { w1, w2, w3, w4, No}; //выходы - w, No - когда в таблице прочерк и выходной функции нет


        public State firstState = State.b1; //начальное состояние
        public State activeState = State.b1; //текущее состояние
        public Exits successW = Exits.No; //текущий выход - выхода нет

        

        //Случайное состояние, где прочерк!
        private State NoState()
        {
            Array value = Enum.GetValues(typeof(State));
            Random rnd = new Random();

            return (State)value.GetValue(rnd.Next(value.Length));
        }
 
        //Воздествие входов
        public Exits Activity(Inputs activeInput)
        {

            switch (activeState)
            {
                case State.b1:
                    switch(activeInput)
                    {
                        case Inputs.z1:
                            activeState = NoState();
                            successW = Exits.No;
                            break;

                        case Inputs.z2:
                            activeState = NoState();
                            successW = Exits.No;
                            break;

                        case Inputs.z3:
                            activeState = State.b4;
                            successW = Exits.w4;
                            break;

                        case Inputs.z4:
                            activeState = NoState();
                            successW = Exits.No; ;
                            break;
                    }
                    break;

                case State.b2:
                    switch (activeInput)
                    {
                        case Inputs.z1:
                            activeState = State.b2;
                            successW = Exits.w1;
                            break;

                        case Inputs.z2:
                            activeState = State.b2;
                            successW = Exits.w1;
                            break;

                        case Inputs.z3:
                            activeState = NoState();
                            successW = Exits.No;
                            break;

                        case Inputs.z4:
                            activeState = NoState();
                            successW = Exits.No;
                            break;
                    }
                    break;

                case State.b3:
                    switch (activeInput)
                    {
                        case Inputs.z1:
                            activeState = State.b1;
                            successW = Exits.w1;
                            break;

                        case Inputs.z2:
                            activeState = NoState();
                            successW = Exits.No;
                            break;

                        case Inputs.z3:
                            activeState = State.b2;
                            successW = Exits.w2;
                            break;

                        case Inputs.z4:
                            activeState = State.b5;
                            successW = Exits.w4;
                            break;
                    }
                    break;

                case State.b4:
                    switch (activeInput)
                    {
                        case Inputs.z1:
                            activeState = NoState();
                            successW = Exits.No;
                            break;

                        case Inputs.z2:
                            activeState = NoState();
                            successW = Exits.No;
                            break;

                        case Inputs.z3:
                            activeState = State.b5;
                            successW = Exits.w1;
                            break;

                        case Inputs.z4:
                            activeState = NoState();
                            successW = Exits.No;
                            break;
                    }
                    break;

                case State.b5:
                    switch (activeInput)
                    {
                        case Inputs.z1:
                            activeState = NoState();
                            successW = Exits.No;
                            break;

                        case Inputs.z2:
                            activeState = State.b1;
                            successW = Exits.w1;
                            break;

                        case Inputs.z3:
                            activeState = NoState();
                            successW = Exits.No;
                            break;

                        case Inputs.z4:
                            activeState = NoState();
                            successW = Exits.No;
                            break;
                    }
                    break;
            }

            return successW;
        }

    }
}
