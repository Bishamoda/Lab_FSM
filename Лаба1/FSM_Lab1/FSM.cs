using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSM_Lab1
{
    public class FSM
    {
        private int _w = 0;

        public enum State {b1, b2, b3, b4, b5 }; 
        public enum Inputs { z1, z2, z3, z4 }; 
        

        public State firstState = State.b1; 
        public State activeState = State.b1;

        int successW = 0;


        private State NoState()
        {
            Array value = Enum.GetValues(typeof(State));
            Random rnd = new Random();

            return (State)value.GetValue(rnd.Next(value.Length));
        }

        public int w1()
        {
            _w = 1;
            return _w;
        }

        public int w2()
        {
            _w = 2;
            return _w;
        }

        public int w3()
        {
            _w = 3;
            return _w;
        }

        public int w4()
        {
            _w = 4;
            return _w;
        }

        public int NoW()
        {
            _w = 0;
            return _w;
        }


        public int  Activity(Inputs activeInput)
        {

            switch (activeState)
            {
                case State.b1:
                    switch(activeInput)
                    {
                        case Inputs.z1:
                            activeState = NoState();
                            successW = NoW();
                            break;

                        case Inputs.z2:
                            activeState = NoState();
                            successW = NoW();
                            break;

                        case Inputs.z3:
                            activeState = State.b4;
                            successW = w4();
                            break;

                        case Inputs.z4:
                            activeState = NoState();
                            successW = NoW();
                            break;
                    }
                    break;

                case State.b2:
                    switch (activeInput)
                    {
                        case Inputs.z1:
                            activeState = State.b2;
                            successW = w1();
                            break;

                        case Inputs.z2:
                            activeState = State.b2;
                            successW = w1();
                            break;

                        case Inputs.z3:
                            activeState = NoState();
                            successW = NoW();
                            break;

                        case Inputs.z4:
                            activeState = NoState();
                            successW = NoW();
                            break;
                    }
                    break;

                case State.b3:
                    switch (activeInput)
                    {
                        case Inputs.z1:
                            activeState = State.b1;
                            successW = w1();
                            break;

                        case Inputs.z2:
                            activeState = NoState();
                            successW = NoW();
                            break;

                        case Inputs.z3:
                            activeState = State.b2;
                            successW = w2();
                            break;

                        case Inputs.z4:
                            activeState = State.b5;
                            successW = w4();
                            break;
                    }
                    break;

                case State.b4:
                    switch (activeInput)
                    {
                        case Inputs.z1:
                            activeState = NoState();
                            successW = NoW();
                            break;

                        case Inputs.z2:
                            activeState = NoState();
                            successW = NoW();
                            break;

                        case Inputs.z3:
                            activeState = State.b5;
                            successW = w1();
                            break;

                        case Inputs.z4:
                            activeState = NoState();
                            successW = NoW();
                            break;
                    }
                    break;

                case State.b5:
                    switch (activeInput)
                    {
                        case Inputs.z1:
                            activeState = NoState();
                            successW = NoW();
                            break;

                        case Inputs.z2:
                            activeState = State.b1;
                            successW = w1();
                            break;

                        case Inputs.z3:
                            activeState = NoState();
                            successW = NoW();
                            break;

                        case Inputs.z4:
                            activeState = NoState();
                            successW = NoW();
                            break;
                    }
                    break;
            }

            return successW;
        }

    }
}
