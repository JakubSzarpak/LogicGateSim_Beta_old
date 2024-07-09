﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GateSim.Models.Classes
{
    /*
     * Truth Table
     * IN  IN  OUT
     * [0] [0] [0]
     * [1] [0] [0]
     * [1] [1] [1]
     */
    public class AndGate : Gate
    {
        public AndGate(uint InputAmount, uint OutputAmount) :
            base(InputAmount, OutputAmount)
        {
            
        }//-----------------------------------------------------------

        protected override void SetOutputs()
        {
            bool areAllInputsFalse = true;

            for (int i = 0; i < inputs.Length; i++)
            {
                if (!inputs[i].In)
                {
                    areAllInputsFalse = false;
                    break;
                }
            }

            for (int i = 0; i < outputs.Length; i++)
            {
                outputs[i].Out = areAllInputsFalse;
            }
        }//--------------------------------------------------------


    }//#####################################################################################
}
