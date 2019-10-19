namespace Logic
{
    public class ChangeColor
    {
        public static MyEnum C;
        public static MyEnum2 C2;
        public enum MyEnum2
        {
            Black,
            Yellow
        }
        public enum MyEnum
        {
            Red,
            RedAndYellow,
            Yellow,
            Green,
        }
        public static void ChangeLight2(object sender, object e)
        {
            switch (C2)
            {
                case MyEnum2.Yellow:
                    C2 = MyEnum2.Black;
                    break;
                case MyEnum2.Black:
                    C2 = MyEnum2.Yellow;
                    break;
                default:
                    break;
            }
        }
        public static void ChangeLight(object sender, object e)
        {
            switch (C)
            {
                case MyEnum.Red:
                    C = MyEnum.RedAndYellow;
                    break;
                case MyEnum.RedAndYellow:
                    C = MyEnum.Green;
                    break;
                case MyEnum.Green:
                    C = MyEnum.Yellow;
                    break;
                case MyEnum.Yellow:
                    C = MyEnum.Red;
                    break;
                default:

                    break;
            }
        }
    }
}
