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
     * [1] [0] [1]
     * [1] [1] [1]
     */
    public class OrGate : Gate
    {
        
        public OrGate(uint InputAmount, uint OutputAmount)
            : base(InputAmount, OutputAmount)
        {
        }//--------------------------------------------------------

        //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$

        protected override void SetOutputs()
        {
            bool isSomeOutputTrue = false;


            for (int i = 0; i < inputs.Length; i++)
            {
                if(inputs[i].In)
                {
                    isSomeOutputTrue = true;
                    break;
                }
            }

            for (int i = 0; i < outputs.Length; i++)
            {
                outputs[i].Out = isSomeOutputTrue;
            }
        }//--------------------------------------------------------------
    }//########################################################
}
