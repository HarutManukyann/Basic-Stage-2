using System;
using System.IO;
using System.Text;

namespace File_Task
{
    class Program
    {
        static void CreateFolder()//TASK 1     
        {
            string path = @"C:\Users\User\source\INTER\Files_Task\Data";
            if (Directory.Exists(path))
            {
                Console.WriteLine((path));
            }
            else
            {
                Directory.CreateDirectory(path);
                Console.WriteLine($"Created file:{path}");
            }
        }
        static void SubFolder() //TASK 2     
        {
            string path = @"C:\Users\User\source\INTER\Files_Task\Data\SubFolder";
            Directory.CreateDirectory(path);
            FileInfo image = new FileInfo(@"C:\Users\User\source\INTER\Files_Task\Data\image.jpg");
            image.Create();
            FileInfo text = new FileInfo(@"C:\Users\User\source\INTER\Files_Task\Data\text.txt");
            text.Create();
            FileInfo document = new FileInfo(@"C:\Users\User\source\INTER\Files_Task\Data\document.pdf");
            document.Create();
        }
        static void Enumirate()//TASK 3     
        {
            string path = @"C:\Users\User\source\INTER\Files_Task\Data";

            string[] folderList = Directory.GetDirectories(path);
            string[] fileList = Directory.GetFiles(path);
            Console.WriteLine("     Folder(es) in Data:");
            foreach (var item in folderList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("     File(es) in Data:");
            foreach (var item in fileList)
            {
                Console.WriteLine(item);
            }
        }
        static void Search() // TASK 4    
        {
            string path = @"C:\Users\User\source\INTER\Files_Task\Data";
            DirectoryInfo dir = new DirectoryInfo(path); // folderi bacvel
            FileInfo[] textFiles = dir.GetFiles("*.txt", SearchOption.AllDirectories);
            foreach (var item in textFiles)
            {
                Console.WriteLine(item);
            }

        }
        static void Delete()// TASK 5   
        {
            string path = @"C:\Users\User\source\INTER\Files_Task\Data";
            DirectoryInfo dir = new DirectoryInfo(path);
            DirectoryInfo[] folderList = dir.GetDirectories();
            FileInfo[] fileList = dir.GetFiles();

            foreach (var item in fileList)
            {
                item.Delete();
            }
            foreach (var item in folderList)
            {
                item.Delete();
            }

        }
        static void CreateFile()//TASK 6       
        {
            string path = @"C:\Users\User\source\INTER\Files_Task\Data\datastore.dat";
            FileInfo file = new FileInfo(path);
            file.Create();
            Console.WriteLine("File Created Succesfully:");
        }

        static void CreateFileTxt() // TASK 7 
        {
            string path = @"C:\Users\User\source\INTER\Files_Task\Data\datastore.txt";
            FileInfo file = new FileInfo(path);
            file.Create();
            Console.WriteLine("File Created Succesfully:");

        }
        static void Writer()  // TASK 8
        {
            string path = @"C:\Users\User\source\INTER\Files_Task\Data\datastore.txt";
            string text = "Hello World";
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.Write(text);
            }
        }
        static void Reader()  // TASK 9  
        {
            string path = @"C:\Users\User\source\INTER\Files_Task\Data\datastore.txt";
            using (StreamReader Read = new StreamReader(path))
            {
                string text = Read.ReadToEnd();
                Console.WriteLine(text);
            }
        }
        static void Main(string[] args)
        {
            //CreateFolder(); //Task 1
            //SubFolder();  //Task 2
            //Enumirate(); //Task 3
            //Search();   //Task 4
            //Delete();  //Task 5
            //CreateFile(); //Task 6
            //Writer(); //Task 7
            //Reader(); //Task 8

            //CreateFileTxt();  //Task 9
        }
    }
}
