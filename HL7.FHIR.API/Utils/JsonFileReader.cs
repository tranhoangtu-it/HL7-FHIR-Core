using System;
using System.IO;

public class JsonFileReader
{
    public static string ReadJsonContent(string folderPath, string fileNameWithoutExtension)
    {
        // Ghép tên file với đuôi .json
        string filePath = Path.Combine(folderPath, $"{fileNameWithoutExtension}.json");

        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException($"Không tìm thấy file: {filePath}");
        }

        // Đọc toàn bộ nội dung JSON và trả về
        return File.ReadAllText(filePath);
    }
}