namespace OneInstanceOnly
{
    // this class to create just one object from class 
    class CreatOneInstance
    {
        private static CreatOneInstance instance;
        private CreatOneInstance()
        {
            Console.WriteLine("you created object");
        }
        public static CreatOneInstance creatObject()
        {
            if (instance == null)
            {
                CreatOneInstance.instance = new CreatOneInstance();
                return CreatOneInstance.instance;
            }
            else
            {
                throw new Exception("you can not create more one object from this class");
            }
        }
    }
    class Program
    {
        static void Main()
        {
            CreatOneInstance obj2 = CreatOneInstance.creatObject();
            try {
                CreatOneInstance obj3 = CreatOneInstance.creatObject();
            } catch (Exception ex) {
                Console.WriteLine(ex);
            }
           
            
           

        }
    }
}