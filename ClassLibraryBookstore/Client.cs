using System.Runtime;
using System.Security.Policy;

namespace lab3Lib;

public class Client {
    // Данные о клиенте
    private string prompt;
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
    }

    // Внешне-доступные функции
    public string GetPrompt() { return this.prompt; }
    public int GetPromptType() { return this.promptType; }
}
