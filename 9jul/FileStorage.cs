using System;

public abstract class FileStorage
{
    public abstract void Upload(String filename);

    public void validateFile()
    {
        Console.WriteLine("Validate file........");
    }
    
}