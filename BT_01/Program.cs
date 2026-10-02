Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("=== Chương trình đoán số ===");

Random random = new Random();
int targetNumber = random.Next(100, 1000); // Máy tính phát sinh ngẫu nhiên số từ 100 đến 999
string targetString = targetNumber.ToString();

int attempt = 1;
const int MAX_GUESS = 7;
string guess = "";
string feedback = "";

while (feedback != "+++" && attempt <= MAX_GUESS)
{
    Console.Write("Lần đoán thứ {0}: ", attempt);
    guess = Console.ReadLine();

    // Kiểm tra hợp lệ trước khi xử lý, tránh crash và không tính lượt nếu nhập sai
    if (guess == null || guess.Length != 3 || !int.TryParse(guess, out int soDoan) || soDoan < 100 || soDoan > 999)
    {
        Console.WriteLine("=> Vui lòng nhập một số có đúng 3 chữ số (100-999).");
        continue;
    }

    feedback = GetFeedback(targetString, guess);
    Console.WriteLine("Phản hồi từ máy tính: {0}", feedback);
    attempt++;
}

// Xác định thắng thua dựa vào feedback
if (feedback == "+++")
{
    Console.WriteLine("Nữoi chơi đã đoán đúng! Trò chơi kết thúc sau {0} lần đoán.", attempt - 1);
    Console.WriteLine("Người chơi thắng cuộc!");
}
else
{
    Console.WriteLine("Người chơi đã đoán 7 lần. Trò chơi kết thúc!");
    Console.WriteLine("Người chơi thua cuộc. Số cần đoán là: {0}", targetNumber);
}

Console.WriteLine("Nhấn phím bất kỳ để thoát...");
Console.ReadKey();

// Hàm xử lý phản hồi dựa trên số đoán và số cần đoán
static string GetFeedback(string target, string guess)
{
    string feedback = "";
    for (int i = 0; i < target.Length; i++)
    {
        if (target[i] == guess[i])
        {
            feedback += "+";
        }
        else if (target.Contains(guess[i].ToString()))
        {
            feedback += "?";
        }
    }
    return feedback;
}