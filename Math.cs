class Math
{
    public Math()
    {

    }

    public float AddNum(float firstNumber, float secondNumber)
    {
        float sum = 0;
        sum += firstNumber;
        sum += secondNumber;

        return sum;
    }

    public float SubtractNum(float firstNumber, float secondNumber)
    {
        float result = 0;
        result += firstNumber;
        result -= secondNumber;

        return result;
    }

    public float MultiplyNum(float firstNumber, float secondNumber)
    {
        float result = 0;
        result = firstNumber * secondNumber;

        return result;
    }
}