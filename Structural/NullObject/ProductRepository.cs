namespace NullObject
{
    public class ProductRepository
    {
        public static AbstractProduct NullInstance { get; } = new NullProduct();

        /*In a real world scenario there would be of course some validation if product returned from, let's say context, is null.*/
        public AbstractProduct GetProductById(int i)
        {
            return NullInstance;
        }
    }
}