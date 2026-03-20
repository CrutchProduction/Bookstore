using System.Runtime;
using System.Security.Policy;

namespace lab3Lib;

public class Client {
    // Данные о клиенте
    private string prompt;
    private string name;
    private int appearanceImage;
    private int promptType;
    
    // Конструктор
    public Client(Random rnd, string[] labels, string[] authors, string[] genres) {
        GeneratePrompt(rnd, labels, authors, genres);
    }

    // Генерация запроса пользователя
    private void GeneratePrompt(Random rnd, string[] labels, string[] authors, string[] genres) {
        this.promptType = rnd.Next(2);
        switch (this.promptType) {
            case 0:
                int index = rnd.Next(labels.Length);
                this.prompt = labels[index] + "|" + authors[index];
                break;
            case 1:
                this.prompt = genres[rnd.Next(genres.Length)];
                break;
        }

        bool gender = rnd.Next(2) == 0;
        string[] firtsNames;
        string[] lastNames;
        if (gender) {
            firtsNames = System.IO.File.ReadAllText("firstNamesM.txt").Split(" ");
            lastNames = System.IO.File.ReadAllText("lastNamesM.txt").Split(" ");
        } else
        {
            firtsNames = System.IO.File.ReadAllText("firstNamesF.txt").Split(" ");
            lastNames = System.IO.File.ReadAllText("lastNamesF.txt").Split(" ");
        }
        this.name = firtsNames[rnd.Next(firtsNames.Length)] + lastNames[rnd.Next(lastNames.Length)];
        bool isPutin = rnd.Next(500) == 200;
        if (!isPutin) {
            this.appearanceImage = rnd.Next(17);
        } else
        {
            this.appearanceImage = -1;
            this.promptType = 2;
            this.prompt = "ZOV zOV voZ OZoV ZOV zOOooV ZOooOOV zov oVz";
        }
    }

    // Внешне-доступные функции
    public string GetPrompt() { return this.prompt; }
    public string GetName() { return this.name; }
    public int GetAppearanceImage() { return this.appearanceImage; }
    public int GetPromptType() { return this.promptType; }
}
