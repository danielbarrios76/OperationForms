using System;

namespace OperationForms.Models
{
    class MathOperations
    {
        public Action<int, int> MessageHandler;

        public int Divide(int A, int B)
        {
            int result = 0;
            if (B != 0)
            {
                result = A / B;
            }
            else
            {
                MessageHandler?.Invoke(A, B);
            }
            return result;
        }
    }
}
