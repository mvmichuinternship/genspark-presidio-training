﻿using RefundMngtModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefundMngtBLLibrary
{
    public interface IAcceptance
    {
        void Rejected(int id);
    }
}
