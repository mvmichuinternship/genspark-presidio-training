﻿using System.Runtime.Serialization;

namespace shoppingCartDALLibrary
{
    [Serializable]
    public class NoCustomerWithGiveIdException : Exception
    {
        string message;
        public NoCustomerWithGiveIdException()
        {
            message = "Customer with the given Id is not present";
        }
        public override string Message => message;

    }
}