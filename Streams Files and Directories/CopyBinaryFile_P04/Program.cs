namespace CopyBinaryFile_P04
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            using (var reader = new FileStream(@"../../../copyMe.png", FileMode.Open))
            {
                using (var writer = new FileStream(@"../../../fileCopy.png", FileMode.Create))
                {
                    while (true)
                    {
                        byte[] buffer = new byte[4096];

                        int total = reader.Read(buffer, 0, buffer.Length);

                        if (total < 1)
                        {
                            break;
                        }

                        writer.Write(buffer, 0, total);
                    }
                }
            }
        }
    }
}
