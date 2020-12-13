using System;

var text = "だくてんテスト";
var result = "";

bool IsSmallAndSymb(char c)
{
    var smallAndSymb = new[] { "ぁ", "ぃ", "ぅ", "ぇ", "ぉ",
                                "ヵ", "ゃ", "ゅ", "ょ",
                                "ァ", "ィ", "ゥ", "ェ", "ォ",
                                "ャ", "ュ", "ョ", "ー", "～",
                                "！", "？", "・", "、", "。","\r","\n"," ","　"};

    foreach (string cc in smallAndSymb)
    {
        if (c.ToString() == cc)
        {
            return false;
        }
    }

    return true;
}

bool Conv(char c)
{
    var daku = new[] { "が", "ぎ", "ぐ", "げ", "ご",
                        "ざ", "じ", "ず", "ぜ", "ぞ",
                        "だ", "ぢ", "づ", "で", "ど",
                        "ば", "び", "ぶ", "べ", "ぼ",
                        "ガ", "ギ", "グ", "ゲ", "ゴ",
                        "ザ", "ジ", "ズ", "ゼ", "ゾ",
                        "ダ", "ヂ", "ヅ", "デ", "ド",
                        "バ", "ビ", "ブ", "ベ", "ボ"};

    var hira = new[] { "か", "き", "く", "け", "こ",
                        "さ", "し", "す", "せ", "そ",
                        "た", "ち", "つ", "て", "と",
                        "は", "ひ", "ふ", "へ", "ほ",
                        "カ", "キ", "ク", "ケ", "コ",
                        "サ", "シ", "ス", "セ", "ソ",
                        "タ", "チ", "ツ", "テ", "ト",
                        "ハ", "ヒ", "フ", "ヘ", "ホ"};


    for (int i = 0; i < daku.Length; i++)
    {
        if (c.ToString() == daku[i])
        {
            result += hira[i] + "゛";
            return false;
        }
    }

    return true;
}

foreach (char c in text)
{
    if (IsSmallAndSymb(c))
    {
        if (Conv(c))
        {
            result += c + "゛";
        }
    }
    else
    {
        result += c;
    }
}

Console.WriteLine(result);
